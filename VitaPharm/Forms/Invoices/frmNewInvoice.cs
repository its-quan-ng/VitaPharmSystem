using DevExpress.XtraEditors;
using System;
using VitaPharm.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace VitaPharm.Forms.Invoices
{
    public partial class frmNewInvoice : DevExpress.XtraEditors.XtraForm
    {
        private PharmacyDbContext context = new PharmacyDbContext();
        private string currentUser;

        public frmNewInvoice(string username)
        {
            currentUser = username;
            InitializeComponent();
        }

        private void frmNewInvoice_Load(object sender, EventArgs e)
        {
            txtInvoiceCode.Text = GenerateNewInvoiceCode();

            var customers = context.Customers
                            .Select(c => new { c.CustomerID, c.CustomerName, c.Contact })
                            .ToList();
            cboCustomer.Properties.DataSource = customers;
            cboCustomer.Properties.DisplayMember = "CustomerName";
            cboCustomer.Properties.ValueMember = "CustomerID";
            cboCustomer.EditValue = null;
        }

        #region Generate new invoice code
        private string GenerateNewInvoiceCode()
        {
            string prefix = "INV";
            string datePart = DateTime.Today.ToString("yyMMdd");
            int countToday = context.Invoices
                                      .Count(i => i.CreatedDate == DateTime.Today) + 1;
            string seqPart = countToday.ToString("D3");

            return $"{prefix}{datePart}{seqPart}";
        }
        #endregion

        #region Handle form events
        private void btnAddToCart_Click(object sender, EventArgs e)
        {

        }


        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void ToggleControls(bool enableEditable)
        {
            txtInvoiceCode.Enabled = false;
            dateCreatedDate.Enabled = false; 
            txtEmployee.Enabled = false; 
            cboCustomer.Enabled = false;
            txtContact.Enabled = false;
            txtQtyAvailable.Enabled = false;
            txtPrice.Enabled = false;       
            txtBaseUnit.Enabled = false;    
            btnAddToCart.Enabled = false;
            btnRemove.Enabled = !false;
            btnAdd.Enabled = !false;
        }

        private void LoadCommodities()
        {
            var commodities = context.Commodities
                .Select(c => new
                {
                    c.CommodityID,
                    c.CommodityName,
                    c.SellingPrice,
                    c.BaseUnit
                })
                .ToList();
            cboCommodity.Properties.DataSource = commodities;
            cboCommodity.Properties.DisplayMember = "CommodityName";
            cboCommodity.Properties.ValueMember = "CommodityID";
            cboCommodity.EditValue = null;
        }
}