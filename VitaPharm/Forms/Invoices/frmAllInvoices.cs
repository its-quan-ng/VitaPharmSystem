using ClosedXML.Excel;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Microsoft.EntityFrameworkCore;
using System.Data;
using VitaPharm.Data;

namespace VitaPharm.Forms.Invoices
{
    public partial class frmAllInvoices : XtraForm
    {
        private PharmacyDbContext context;
        private BindingSource bsAllInvoices;
        bool isAdmin = string.Equals(CurrentUser.Role, "admin", StringComparison.OrdinalIgnoreCase);

        public frmAllInvoices()
        {
            InitializeComponent();
            repobtnViewDetail.ButtonClick += repobtnViewDetail_ButtonClick;
        }

        private void frmAllInvoices_Load(object sender, EventArgs e)
        {
            LoadInvoices();
            btnNewInvoice.Enabled = !isAdmin;
        }

        private void LoadInvoices()
        {
            try
            {
                context = new PharmacyDbContext();

                IQueryable<Invoice> query = context.Invoices
                    .Include(i => i.Customer)
                    .Include(i => i.Employee);

                if (!isAdmin)
                {
                    query = query.Where(i => i.Employee.EmployeeID == CurrentUser.EmployeeID);
                }

                var invoiceData = query
                    .AsEnumerable()
                    .Select((i, idx) => new
                    {
                        ID = idx + 1,
                        i.InvoiceID,
                        i.InvoiceCode,
                        i.CreatedDate,
                        CustomerName = i.Customer?.CustomerName ?? "N/A",
                        EmployeeName = i.Employee?.EmployeeName ?? "N/A",
                        i.InvoiceStatus,
                        i.Note,
                    })
                    .ToList();
                bsAllInvoices = new BindingSource
                {
                    DataSource = invoiceData
                };
                gridControl.DataSource = bsAllInvoices;

                HideColumnSafely(gridView, "InvoiceID");
                gridView.OptionsView.ShowGroupPanel = false;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error loading invoices: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void HideColumnSafely(GridView view, string fieldName)
        {
            var col = view.Columns[fieldName];
            if (col != null)
            {
                col.Visible = false;
                col.OptionsColumn.ShowInCustomizationForm = false;
            }
        }

        private void btnNewInvoice_Click(object sender, EventArgs e)
        {
            var newInvoiceForm = new frmNewInvoice(CurrentUser.Username);
            newInvoiceForm.ShowDialog();
            LoadInvoices();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            frmAllInvoices_Load(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var result = XtraMessageBox.Show("Are you sure you want to close this form?", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void repobtnViewDetail_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int rowHandle = gridView.FocusedRowHandle;
            if (rowHandle < 0) return;

            var invoiceCode = gridView.GetRowCellValue(rowHandle, "InvoiceCode");
            if (invoiceCode == null) return;

            var detailForm = new frmInvoiceDetail((string)invoiceCode);
            detailForm.ShowDialog();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files|*.xlsx;*.xls",
                Title = "Export Invoices to Excel",
                FileName = "IV_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var exportContext = new PharmacyDbContext())
                    {
                        #region Export All Invoices
                        DataTable tableInvoices = new DataTable();
                        tableInvoices.Columns.AddRange(new DataColumn[] {
                            new DataColumn("ID", typeof(int)),
                            new DataColumn("InvoiceCode", typeof(string)),
                            new DataColumn("CreatedDate", typeof(string)),
                            new DataColumn("CustomerName", typeof(string)),
                            new DataColumn("EmployeeName", typeof(string)),
                            new DataColumn("InvoiceStatus", typeof(string)),
                            new DataColumn("Note", typeof(string))
                        });

                        IQueryable<Invoice> invoiceQuery = exportContext.Invoices
                            .Include(i => i.Customer)
                            .Include(i => i.Employee)
                            .Include(i => i.InvoiceDetail)
                                .ThenInclude(id => id.Batch)
                                    .ThenInclude(b => b.Commodity);

                        if (!isAdmin)
                        {
                            invoiceQuery = invoiceQuery.Where(i => i.Employee.EmployeeID == CurrentUser.EmployeeID);
                        }

                        var invoices = invoiceQuery.ToList();

                        if (invoices != null && invoices.Count > 0)
                        {
                            int index = 1;
                            foreach (var invoice in invoices)
                            {
                                tableInvoices.Rows.Add(
                                    index++,
                                    invoice.InvoiceCode,
                                    invoice.CreatedDate.ToString("dd/MM/yyyy HH:mm"),
                                    invoice.Customer?.CustomerName ?? "N/A",
                                    invoice.Employee?.EmployeeName ?? "N/A",
                                    invoice.InvoiceStatus,
                                    invoice.Note ?? ""
                                );
                            }
                        }
                        #endregion

                        #region Export Invoice Details
                        DataTable tableInvoiceDetails = new DataTable();
                        tableInvoiceDetails.Columns.AddRange(new DataColumn[] {
                            new DataColumn("InvoiceCode", typeof(string)),
                            new DataColumn("CommodityName", typeof(string)),
                            new DataColumn("BatchCode", typeof(string)),
                            new DataColumn("Quantity", typeof(int)),
                            new DataColumn("BaseUnit", typeof(string)),
                            new DataColumn("UnitPrice", typeof(decimal)),
                            new DataColumn("Amount", typeof(decimal)),
                            new DataColumn("TaxRate", typeof(float)),
                            new DataColumn("TaxAmount", typeof(decimal)),
                            new DataColumn("TotalAmount", typeof(decimal))
                        });

                        foreach (var invoice in invoices)
                        {
                            if (invoice.InvoiceDetail != null && invoice.InvoiceDetail.Any())
                            {
                                foreach (var detail in invoice.InvoiceDetail)
                                {
                                    decimal amount = detail.Amount;
                                    decimal taxAmount = (amount * (decimal)invoice.TaxRate) / 100;
                                    decimal totalAmount = amount + taxAmount;

                                    tableInvoiceDetails.Rows.Add(
                                        invoice.InvoiceCode,
                                        detail.Batch?.Commodity?.CommodityName ?? "N/A",
                                        detail.Batch?.BatchCode ?? "N/A",
                                        detail.Quantity,
                                        detail.Batch?.Commodity?.BaseUnit ?? "N/A",
                                        detail.UnitPrice,
                                        amount,
                                        invoice.TaxRate,
                                        taxAmount,
                                        totalAmount
                                    );
                                }
                            }
                        }

                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            var sheet1 = wb.Worksheets.Add(tableInvoices, "IV_" + DateTime.Now.ToString("yyyyMMdd_HHmmss"));
                            sheet1.Columns().AdjustToContents();

                            var headerRange1 = sheet1.Range(1, 1, 1, tableInvoices.Columns.Count);
                            headerRange1.Style.Font.Bold = true;
                            headerRange1.Style.Fill.BackgroundColor = XLColor.LightBlue;

                            var sheet2 = wb.Worksheets.Add(tableInvoiceDetails, "IVD_" + DateTime.Now.ToString("yyyyMMdd_HHmmss"));
                            sheet2.Columns().AdjustToContents();

                            var headerRange2 = sheet2.Range(1, 1, 1, tableInvoiceDetails.Columns.Count);
                            headerRange2.Style.Font.Bold = true;
                            headerRange2.Style.Fill.BackgroundColor = XLColor.LightGreen;

                            var unitPriceCol = sheet2.Column("F");
                            var amountCol = sheet2.Column("G");
                            var taxAmountCol = sheet2.Column("I");
                            var totalAmountCol = sheet2.Column("J");

                            unitPriceCol.Style.NumberFormat.Format = "#,##0";
                            amountCol.Style.NumberFormat.Format = "#,##0";
                            taxAmountCol.Style.NumberFormat.Format = "#,##0";
                            totalAmountCol.Style.NumberFormat.Format = "#,##0";

                            var taxRateCol = sheet2.Column("H");
                            taxRateCol.Style.NumberFormat.Format = "0.##\"%\"";

                            wb.SaveAs(saveFileDialog.FileName);
                            XtraMessageBox.Show($"Export completed successfully!",
                                "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        #endregion
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show($"Error exporting data: {ex.Message}\n\nStack Trace: {ex.StackTrace}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}