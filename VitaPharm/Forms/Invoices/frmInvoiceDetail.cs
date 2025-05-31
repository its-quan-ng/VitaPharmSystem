using DevExpress.XtraEditors;
using Microsoft.EntityFrameworkCore;
using System.Data;
using VitaPharm.Data;

namespace VitaPharm.Forms.Invoices
{
    public partial class frmInvoiceDetail : XtraForm
    {
        private PharmacyDbContext context = new PharmacyDbContext();
        private string invoiceCode;
        private Invoice currentInvoice;
        private BindingSource bsInvoiceDetails;

        public frmInvoiceDetail(string invoiceCode)
        {
            this.invoiceCode = invoiceCode;
            InitializeComponent();
        }

        private void frmInvoiceDetail_Load(object sender, EventArgs e)
        {
            LoadInvoiceDetails();
        }

        private void LoadInvoiceDetails()
        {
            try
            {
                currentInvoice = context.Invoices
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
                txtCustomer.EditValue = currentInvoice.Customer.CustomerName;

                var invoiceDetailData = currentInvoice.InvoiceDetail
                    .Select(id => new
                    {
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

                decimal totalAmount = invoiceDetailData.Sum(x => x.Amount);
                lblTotal.Text = totalAmount.ToString("N2");

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
                unitPriceColumn.DisplayFormat.FormatString = "N2";
            }

            var amountColumn = gridView.Columns["Amount"];
            if (amountColumn != null)
            {
                amountColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                amountColumn.DisplayFormat.FormatString = "N2";
            }

            gridView.OptionsView.ShowGroupPanel = false;
            gridView.BestFitColumns();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            frmInvoiceDetail_Load(sender, e);
        }
    }
}