using DevExpress.XtraEditors;
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
            LoadCustomers();
            LoadInvoiceDetails();
        }

        private void LoadInvoiceDetails()
        {

        }

        private void LoadCustomers()
        {
            try
            {
                var customers = context.Customers
                    .Select(c => new
                    {
                        c.CustomerID,
                        c.CustomerName,
                        c.Contact,
                        c.CustomerAddress
                    })
                    .ToList();

                cboCustomer.Properties.DataSource = customers;
                cboCustomer.Properties.DisplayMember = "CustomerName";
                cboCustomer.Properties.ValueMember = "CustomerID";
                cboCustomer.Properties.PopulateColumns();

                if (cboCustomer.Properties.Columns.Count > 0)
                {
                    cboCustomer.Properties.Columns["CustomerID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error loading customers: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnReload_Click(object sender, EventArgs e)
        {
            frmInvoiceDetail_Load(sender, e);
        }

    }
}