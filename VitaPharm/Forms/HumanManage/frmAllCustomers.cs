using System.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using VitaPharm.Data;

namespace VitaPharm.Forms.HumanManage
{
    public partial class frmAllCustomers : XtraForm
    {
        private PharmacyDbContext context;
        private BindingSource bsCustomers;
        private int currentCustomerId;

        private class CustomerView
        {
            public int ID { get; set; }              
            public int CustomerID { get; set; }      
            public string CustomerName { get; set; }
            public string Sex { get; set; }
            public string Contact { get; set; }
            public string CustomerAddress { get; set; }
        }

        public frmAllCustomers()
        {
            InitializeComponent();
            bsCustomers = new BindingSource();
            gridControl.DataSource = bsCustomers;
            gridView.FocusedRowChanged += GridView_FocusedRowChanged;
        }

        private void frmAllCustomers_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
            ToggleControls(false);
        }

        private void LoadCustomerData()
        {
            context?.Dispose();
            context = new PharmacyDbContext();

            var list = context.Customers
                .Select(c => new
                {
                    c.CustomerID,
                    c.CustomerName,
                    c.Sex,
                    c.Contact,
                    c.CustomerAddress
                })
                .AsEnumerable() 
                .Select((x, idx) => new CustomerView
                {
                    ID = idx + 1,
                    CustomerID = x.CustomerID,
                    CustomerName = x.CustomerName,
                    Sex = x.Sex,
                    Contact = x.Contact,
                    CustomerAddress = x.CustomerAddress
                })
                .ToList();

            bsCustomers.DataSource = list;
            gridControl.RefreshDataSource();
        }

        private void GridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (bsCustomers.Current is CustomerView cv)
            {
                currentCustomerId = cv.CustomerID;

                txtFullName.Text = cv.CustomerName;
                chkFemale.Checked = (cv.Sex == "F");
                txtContact.Text = cv.Contact;
                txtAddress.Text = cv.CustomerAddress;
            }
        }

        private void ToggleControls(bool enabled)
        {
            txtFullName.Enabled = enabled;
            chkFemale.Enabled = enabled;
            txtContact.Enabled = enabled;
            txtAddress.Enabled = enabled;

            btnAdd.Enabled = true;
            btnEdit.Enabled = !enabled;
            btnSave.Enabled = enabled;
            btnReload.Enabled = true;
            btnDelete.Enabled = enabled;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ToggleControls(true);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            frmAllCustomers_Load(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                XtraMessageBox.Show("Full Name cannot be empty!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return;
            }

            if (XtraMessageBox.Show("Save changes to this customer?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                using var saveCtx = new PharmacyDbContext();
                var cust = saveCtx.Customers
                    .FirstOrDefault(c => c.CustomerID == currentCustomerId);
                if (cust == null)
                {
                    XtraMessageBox.Show("Customer not found.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                cust.CustomerName = txtFullName.Text.Trim();
                cust.Sex = chkFemale.Checked ? "F" : "M";
                cust.Contact = txtContact.Text.Trim();
                cust.CustomerAddress = txtAddress.Text.Trim();

                saveCtx.SaveChanges();

                XtraMessageBox.Show("Customer updated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmAllCustomers_Load(sender, e);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error saving data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}