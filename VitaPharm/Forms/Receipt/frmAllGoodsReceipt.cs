using ClosedXML.Excel;
using DevExpress.XtraEditors;
using Microsoft.EntityFrameworkCore;
using System.Data;
using VitaPharm.Data;

namespace VitaPharm.Forms.Receipt
{
    public partial class frmAllGoodsReceipt : XtraForm
    {
        private PharmacyDbContext context = new PharmacyDbContext();
        private string currentUser;

        public frmAllGoodsReceipt(string username)
        {
            InitializeComponent();
            currentUser = username;
            repobtnViewDetail.ButtonClick += repobtnViewDetail_ButtonClick;
            LoadReceipts();
        }

        private void frmAllGoodsReceipt_Load(object sender, EventArgs e)
        {
            LoadReceipts();

            if (!string.IsNullOrEmpty(CurrentUser.Role) &&
                CurrentUser.Role.Trim().Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                btnDeactive.Enabled = false;
            }
            else
            {
                btnDeactive.Enabled = true;
            }
        }

        private void btnNewGoodsReceipt_Click(object sender, EventArgs e)
        {
            var newBatchForm = new frmNewGoodsReceipt(currentUser);
            newBatchForm.ShowDialog();
            LoadReceipts();
        }

        private void btnDeactive_Click(object sender, EventArgs e)
        {
            int rowHandle = gridView.FocusedRowHandle;
            if (rowHandle < 0)
            {
                XtraMessageBox.Show("Please select a receipt to deactivate.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var receiptID = gridView.GetRowCellValue(rowHandle, "ReceiptID");
            if (receiptID == null)
            {
                XtraMessageBox.Show("Invalid selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (XtraMessageBox.Show("Are you sure you want to deactivate this receipt?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var receipt = context.GoodsReceipts.FirstOrDefault(r => r.ReceiptID == (int)receiptID);
                if (receipt != null)
                {
                    receipt.ReceiptStatus = "Canceled";
                    context.SaveChanges();
                    LoadReceipts();
                    XtraMessageBox.Show("Receipt deactivated.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            frmAllGoodsReceipt_Load(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Do you want to exit this screen?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void LoadReceipts()
        {
            IQueryable<GoodsReceipt> receiptQuery = context.GoodsReceipts;

            if (CurrentUser.Role.Trim().Equals("user", StringComparison.OrdinalIgnoreCase))
            {
                receiptQuery = receiptQuery.Where(r => r.Employee.EmployeeID == CurrentUser.EmployeeID);
            }

            var receipts = receiptQuery
                .AsEnumerable()
                .Select((r, idx) => new
                {
                    ID = idx + 1,
                    r.ReceiptID,
                    r.ReceiptCode,
                    r.ReceiptDate,
                    r.SupplierName,
                    r.Note,
                    r.ReceiptStatus
                })
                .ToList();
            gridControl.DataSource = receipts;
        }

        private void repobtnViewDetail_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int rowHandle = gridView.FocusedRowHandle;
            if (rowHandle < 0) return;

            var receiptID = gridView.GetRowCellValue(rowHandle, "ReceiptID");
            if (receiptID == null) return;

            var detailForm = new frmGoodsReceiptDetail((int)receiptID);
            detailForm.ShowDialog();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files|*.xlsx;*.xls",
                Title = "Export Receipts to Excel",
                FileName = "GoodsReceipts_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable tableGoodsReceipts = new DataTable();
                    tableGoodsReceipts.Columns.AddRange(new DataColumn[] {
                        new DataColumn("ID", typeof(int)),             
                        new DataColumn("ReceiptCode", typeof(string)),
                        new DataColumn("ReceiptDate", typeof(DateTime)),
                        new DataColumn("SupplierName", typeof(string)),
                        new DataColumn("EmployeeName", typeof(string)),
                        new DataColumn("Note", typeof(string)),
                        new DataColumn("ReceiptStatus", typeof(string))
                    });

                 
                    IQueryable<GoodsReceipt> receiptQuery = context.GoodsReceipts
                        .Include(r => r.Employee);

                    if (CurrentUser.Role.Trim().Equals("user", StringComparison.OrdinalIgnoreCase))
                    {
                        receiptQuery = receiptQuery.Where(r => r.Employee.EmployeeID == CurrentUser.EmployeeID);
                    }

                    var receipts = receiptQuery.ToList();
                    if (receipts != null && receipts.Count > 0)
                    {
                        int index = 1;
                        foreach (var r in receipts)
                        {
                            tableGoodsReceipts.Rows.Add(
                                index++,                            
                                r.ReceiptCode,
                                r.ReceiptDate,
                                r.SupplierName,
                                r.Employee?.EmployeeName ?? "",
                                r.Note ?? "",
                                r.ReceiptStatus
                            );
                        }
                    }

                    DataTable tableGoodsReceiptDetails = new DataTable();
                    tableGoodsReceiptDetails.Columns.AddRange(new DataColumn[] {
                        new DataColumn("ReceiptCode", typeof(string)),      
                        new DataColumn("BatchCode", typeof(string)),
                        new DataColumn("CommodityName", typeof(string)),
                        new DataColumn("Manufacturer", typeof(string)),
                        new DataColumn("BaseUnit", typeof(string)),
                        new DataColumn("MfgDate", typeof(DateTime)),
                        new DataColumn("ExpDate", typeof(DateTime)),
                        new DataColumn("PurchasePrice", typeof(decimal)),
                        new DataColumn("Quantity", typeof(int)),
                        new DataColumn("Amount", typeof(decimal))
                    });

                    var receiptIds = receipts.Select(r => r.ReceiptID).ToList();
                    var receiptDetails = context.GoodsReceiptDetails
                        .Include(d => d.GoodsReceipt)
                        .Include(d => d.Batch)
                        .Include(d => d.Batch.Commodity)
                        .Where(d => receiptIds.Contains(d.GoodsReceipt.ReceiptID))
                        .ToList();

                    if (receiptDetails != null && receiptDetails.Count > 0)
                    {
                        foreach (var d in receiptDetails)
                        {
                            decimal amount = d.QtyIn * (d.Batch?.PurchasePrice ?? 0);
                            tableGoodsReceiptDetails.Rows.Add(
                                d.GoodsReceipt.ReceiptCode,     
                                d.Batch?.BatchCode ?? "",
                                d.Batch?.Commodity?.CommodityName ?? "",
                                d.Batch?.Commodity?.Manufacturer ?? "",
                                d.Batch?.Commodity?.BaseUnit ?? "",
                                d.Batch?.MfgDate,
                                d.Batch?.ExpDate,
                                d.Batch?.PurchasePrice ?? 0,
                                d.QtyIn,
                                amount
                            );
                        }
                    }

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet1 = wb.Worksheets.Add(tableGoodsReceipts, "GoodsReceipts");
                        sheet1.Columns().AdjustToContents();

                        var sheet2 = wb.Worksheets.Add(tableGoodsReceiptDetails, "GoodsReceiptDetails");
                        sheet2.Columns().AdjustToContents();

                        wb.SaveAs(saveFileDialog.FileName);
                        XtraMessageBox.Show($"Export completed successfully!",
                            "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
