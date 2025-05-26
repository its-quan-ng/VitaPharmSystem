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
        private bool isInAddMode = false;

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
            isInAddMode = false;
            LoadCustomerData();
            ToggleControls(false);
        }

        private void LoadCustomerData()
        {
            var bindingSource = new BindingSource();

            context?.Dispose();
            context = new PharmacyDbContext();
            var customers = context.Customers
                .Select(c => new
                {
                    c.CustomerID,
                    c.CustomerName,
                    c.Sex,
                    c.Contact,
                    c.CustomerAddress
                }).AsEnumerable()
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

            bindingSource.DataSource = customers;

            txtFullName.DataBindings.Clear();
            txtFullName.DataBindings.Add(
                "Text", bindingSource, nameof(Customer.CustomerName),
                true, DataSourceUpdateMode.Never);

            chkFemale.DataBindings.Clear();
            var chkSex = new Binding("Checked", bindingSource, nameof(Customer.Sex));
            chkSex.Format += (s, ev) => ev.Value = (ev.Value as string) == "F";
            chkSex.Parse += (s, ev) => ev.Value = ((bool)ev.Value) ? "F" : "M";
            chkFemale.DataBindings.Add(chkSex);

            txtContact.DataBindings.Clear();
            txtContact.DataBindings.Add(
                "Text", bindingSource, nameof(Customer.Contact),
                true, DataSourceUpdateMode.Never);

            txtAddress.DataBindings.Clear();
            txtAddress.DataBindings.Add(
                "Text", bindingSource, nameof(Customer.CustomerAddress),
                true, DataSourceUpdateMode.Never);

            gridControl.DataSource = bindingSource;
            ToggleControls(false);
        }

        private void GridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (isInAddMode) return;
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

            btnAdd.Enabled = !enabled;
            btnEdit.Enabled = !enabled;
            btnSave.Enabled = enabled;
            btnReload.Enabled = true;
            btnDelete.Enabled = true;
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
                using var saveContext = new PharmacyDbContext();
                if (currentCustomerId == 0)
                {
                    var c = new Customer
                    {
                        CustomerName = txtFullName.Text.Trim(),
                        Sex = chkFemale.Checked ? "F" : "M",
                        Contact = txtContact.Text.Trim(),
                        CustomerAddress = txtAddress.Text.Trim()
                    };
                    saveContext.Customers.Add(c);
                    saveContext.SaveChanges();
                    XtraMessageBox.Show("Customer added successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    var cus = saveContext.Customers
                    .FirstOrDefault(c => c.CustomerID == currentCustomerId);
                    if (cus == null)
                    {
                        XtraMessageBox.Show("Customer not found.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    cus.CustomerName = txtFullName.Text.Trim();
                    cus.Sex = chkFemale.Checked ? "F" : "M";
                    cus.Contact = txtContact.Text.Trim();
                    cus.CustomerAddress = txtAddress.Text.Trim();

                    saveContext.SaveChanges();

                    XtraMessageBox.Show("Customer updated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                frmAllCustomers_Load(sender, e);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error saving data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (currentCustomerId == 0)
            {
                XtraMessageBox.Show(
                    "Please select a customer to delete.",
                    "Delete Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var confirm = XtraMessageBox.Show(
                "Are you sure you want to delete this customer?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            try
            {
                using var delCtx = new PharmacyDbContext();
                var cust = delCtx.Customers
                                 .FirstOrDefault(c => c.CustomerID == currentCustomerId);
                if (cust == null)
                {
                    XtraMessageBox.Show(
                        "Customer not found in database.",
                        "Delete Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                delCtx.Customers.Remove(cust);
                delCtx.SaveChanges();

                XtraMessageBox.Show(
                    "Customer deleted successfully.",
                    "Deleted",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                frmAllCustomers_Load(sender, e);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(
                    $"Error deleting customer: {ex.Message}",
                    "Delete Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isInAddMode = true;
            currentCustomerId = 0;
            txtFullName.Text = string.Empty;
            chkFemale.Checked = false;
            txtContact.Text = string.Empty;
            txtAddress.Text = string.Empty;
            ToggleControls(true);
            txtFullName.Focus();
        }
    }
}