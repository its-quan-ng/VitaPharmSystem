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

        #region Fetch data
        private void LoadCustomerData()
        {
            try
            {
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

                bsCustomers.DataSource = customers;
                SetupDataBindings();

                ToggleControls(false);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error loading customer data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupDataBindings()
        {
            txtFullName.DataBindings.Clear();
            chkFemale.DataBindings.Clear();
            txtContact.DataBindings.Clear();
            txtAddress.DataBindings.Clear();

            txtFullName.DataBindings.Add(
                "Text", bsCustomers, nameof(CustomerView.CustomerName),
                true, DataSourceUpdateMode.Never);

            var chkSex = new Binding("Checked", bsCustomers, nameof(CustomerView.Sex));
            chkSex.Format += (s, ev) => ev.Value = (ev.Value as string) == "F";
            chkSex.Parse += (s, ev) => ev.Value = ((bool)ev.Value) ? "F" : "M";
            chkFemale.DataBindings.Add(chkSex);

            txtContact.DataBindings.Add(
                "Text", bsCustomers, nameof(CustomerView.Contact),
                true, DataSourceUpdateMode.Never);

            txtAddress.DataBindings.Add(
                "Text", bsCustomers, nameof(CustomerView.CustomerAddress),
                true, DataSourceUpdateMode.Never);
        }
        #endregion

        private void GridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (isInAddMode) return;

            var selectedRow = gridView.GetFocusedRow();
            if (selectedRow is CustomerView cv)
            {
                currentCustomerId = cv.CustomerID;
            }

            ToggleControls(false);
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
            btnDelete.Enabled = !enabled; 
        }

        #region Handle button clicks
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (currentCustomerId == 0)
            {
                XtraMessageBox.Show("Please select a customer to edit.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ToggleControls(true);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            isInAddMode = false;
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
                    var newCustomer = new Customer
                    {
                        CustomerName = txtFullName.Text.Trim(),
                        Sex = chkFemale.Checked ? "F" : "M",
                        Contact = txtContact.Text.Trim(),
                        CustomerAddress = txtAddress.Text.Trim()
                    };

                    saveContext.Customers.Add(newCustomer);
                    saveContext.SaveChanges();

                    XtraMessageBox.Show("Customer added successfully!", 
                        "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var existingCustomer = saveContext.Customers
                        .FirstOrDefault(c => c.CustomerID == currentCustomerId);

                    if (existingCustomer == null)
                    {
                        XtraMessageBox.Show("Customer not found.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    existingCustomer.CustomerName = txtFullName.Text.Trim();
                    existingCustomer.Sex = chkFemale.Checked ? "F" : "M";
                    existingCustomer.Contact = txtContact.Text.Trim();
                    existingCustomer.CustomerAddress = txtAddress.Text.Trim();

                    saveContext.SaveChanges();

                    XtraMessageBox.Show("Customer updated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                isInAddMode = false;
                LoadCustomerData();
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
                XtraMessageBox.Show("Please select a customer to delete.",
                    "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (XtraMessageBox.Show("Are you sure you want to delete this customer?\n\nThis action cannot be undone.",
                "Confirm Delete", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                using var deleteContext = new PharmacyDbContext();

                var customerToDelete = deleteContext.Customers.Find(currentCustomerId);
                if (customerToDelete == null)
                {
                    XtraMessageBox.Show("Customer not found!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                deleteContext.Customers.Remove(customerToDelete);
                deleteContext.SaveChanges();

                XtraMessageBox.Show("Customer deleted successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                currentCustomerId = 0;
                LoadCustomerData();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error deleting customer: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isInAddMode = true;
            currentCustomerId = 0;

            txtFullName.DataBindings.Clear();
            chkFemale.DataBindings.Clear();
            txtContact.DataBindings.Clear();
            txtAddress.DataBindings.Clear();

            txtFullName.Text = string.Empty;
            chkFemale.Checked = false;
            txtContact.Text = string.Empty;
            txtAddress.Text = string.Empty;

            ToggleControls(true);
            txtFullName.Focus();
        }
        #endregion

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            context?.Dispose();
            base.OnFormClosed(e);
        }
    }
}