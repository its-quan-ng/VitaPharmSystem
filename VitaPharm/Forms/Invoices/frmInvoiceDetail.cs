using DevExpress.XtraEditors;
using Microsoft.EntityFrameworkCore;
using System.Data;
using VitaPharm.Data;
using DevExpress.XtraReports.UI;

namespace VitaPharm.Forms.Invoices
{
    public partial class frmInvoiceDetail : XtraForm
    {
        private PharmacyDbContext context = new PharmacyDbContext();
        private string invoiceCode;
        private BindingSource bsInvoiceDetails;

        public frmInvoiceDetail(string invoiceCode)
        {
            InitializeComponent();
            this.invoiceCode = invoiceCode;
        }

        private void frmInvoiceDetail_Load(object sender, EventArgs e)
        {
            LoadInvoiceDetails();
        }

        private void LoadInvoiceDetails()
        {
            try
            {
                context?.Dispose();
                context = new PharmacyDbContext();

                var currentInvoice = context.Invoices
                    .Include(i => i.Customer)
                    .Include(i => i.Employee)
                    .Include(i => i.InvoiceDetail)
                        .ThenInclude(id => id.Batch)
                            .ThenInclude(b => b.Commodity)
                    .FirstOrDefault(i => i.InvoiceCode == invoiceCode);

                if (currentInvoice == null)
                {
                    XtraMessageBox.Show("Invoice not found!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                txtInvoiceCode.Text = currentInvoice.InvoiceCode;
                txtEmployee.Text = currentInvoice.Employee?.EmployeeName ?? "N/A";
                deCreatedDate.DateTime = currentInvoice.CreatedDate;
                txtCustomer.Text = currentInvoice.Customer.CustomerName;

                var invoiceDetailData = currentInvoice.InvoiceDetail
                    .Select((id, idx) => new
                    {
                        ID = idx + 1,
                        id.InvoiceDetailID,
                        CommodityName = id.Batch?.Commodity?.CommodityName ?? "N/A",
                        BatchCode = id.Batch?.BatchCode ?? "N/A",
                        id.Quantity,
                        BaseUnit = id.Batch?.Commodity?.BaseUnit ?? "N/A",
                        id.UnitPrice,
                        id.Amount,
                        OnHand = id.Batch?.QtyAvailable ?? 0
                    })
                    .ToList();

                bsInvoiceDetails = new BindingSource
                {
                    DataSource = invoiceDetailData
                };

                gridControl.DataSource = bsInvoiceDetails;

                decimal subtotal = invoiceDetailData.Sum(x => x.Amount);
                decimal taxAmount = (subtotal * (decimal)currentInvoice.TaxRate) / 100;
                decimal totalAmount = subtotal + taxAmount;

                lblTax.Text = (currentInvoice.TaxRate) + "%"; 
                lblTotal.Text = totalAmount.ToString("#,##0") + " VND"; 

                SetFormReadOnly();
                ConfigureGridView();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error loading invoice details: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetFormReadOnly()
        {
            txtInvoiceCode.Properties.ReadOnly = true;
            txtEmployee.Properties.ReadOnly = true;
            deCreatedDate.Properties.ReadOnly = true;
            txtCustomer.Properties.ReadOnly = true;

            gridView.OptionsBehavior.Editable = false;
        }

        private void ConfigureGridView()
        {
            var idColumn = gridView.Columns["InvoiceDetailID"];
            if (idColumn != null)
            {
                idColumn.Visible = false;
                idColumn.OptionsColumn.ShowInCustomizationForm = false;
            }

            var unitPriceColumn = gridView.Columns["UnitPrice"];
            if (unitPriceColumn != null)
            {
                unitPriceColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                unitPriceColumn.DisplayFormat.FormatString = "#,##0";
            }

            var amountColumn = gridView.Columns["Amount"];
            if (amountColumn != null)
            {
                amountColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                amountColumn.DisplayFormat.FormatString = "#,##0";
            }
            gridView.BestFitColumns();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadInvoiceDetails();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = XtraMessageBox.Show("Are you sure you want to close this form?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var report = new rptInvoiceDetail();
            report.LoadData(invoiceCode);
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }
    }
}