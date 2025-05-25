using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using Microsoft.EntityFrameworkCore;
using VitaPharm.Data;

namespace VitaPharm.Forms.HumanManage
{
    public partial class frmAllUsers : XtraForm
    {
        private PharmacyDbContext context;
        private int currentAccountId = 0;

        public frmAllUsers()
        {
            InitializeComponent();
            this.Load += frmAllUsers_Load;
            gridView.FocusedRowChanged += GridView_FocusedRowChanged;
        }

        private void frmAllUsers_Load(object sender, EventArgs e)
        {
            LoadUsersData();
            ToggleControls(false);
        }

        private void LoadUsersData()
        {
            context?.Dispose();
            context = new PharmacyDbContext();
            var users = context.Accounts
                .Include(acc => acc.Employee)
                .Select(acc => new
                {
                    acc.AccountID,
                    acc.Username,
                    EmployeeName = acc.Employee.EmployeeName,
                    acc.Employee.Sex,
                    acc.Employee.Birthday,
                    acc.Employee.Contact,
                    acc.Employee.EmployeeAddress,
                    acc.UserRole,
                    acc.IsActive,
                    acc.UserPassword,
                    acc.Employee.EmployeeID
                })
                .ToList();
            gridControl.DataSource = users;
        }

        private void GridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            var row = gridView.GetRow(e.FocusedRowHandle) as dynamic;
            if (row == null) return;

            currentAccountId = row.AccountID;
            txtUserName.Text = row.Username;
            txtFullName.Text = row.EmployeeName;
            chkFemale.Checked = (row.Sex == "F");
            dtpBirthday.DateTime = (DateTime)row.Birthday;
            txtContact.Text = row.Contact;
            txtAddress.Text = row.EmployeeAddress;
            cboRole.SelectedItem = row.UserRole;
            chkIsActive.Checked = (row.IsActive == "Active");
        }

        private void ToggleControls(bool isEnabled)
        {
            txtUserName.Enabled = isEnabled;
            txtFullName.Enabled = isEnabled;
            chkFemale.Enabled = isEnabled;
            dtpBirthday.Enabled = isEnabled;
            txtContact.Enabled = isEnabled;
            txtAddress.Enabled = isEnabled;
            cboRole.Enabled = isEnabled;
            chkIsActive.Enabled = isEnabled;
            btnSave.Enabled = isEnabled;
            btnCancel.Enabled = isEnabled;
            btnEdit.Enabled = !isEnabled;
            btnReload.Enabled = true;
            btnNewUser.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ToggleControls(true);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            frmAllUsers_Load(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = XtraMessageBox.Show(
                "Are you sure you want to cancel the changes?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frmAllUsers_Load(sender, e);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUserName.Text))
                {
                    XtraMessageBox.Show("Username cannot be empty!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtFullName.Text))
                {
                    XtraMessageBox.Show("Employee name cannot be empty!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFullName.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtContact.Text))
                {
                    XtraMessageBox.Show("Contact number cannot be empty!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContact.Focus();
                    return;
                }

                if (cboRole.SelectedItem == null)
                {
                    XtraMessageBox.Show("Please select a role!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboRole.Focus();
                    return;
                }

                var result = XtraMessageBox.Show(
                    "Are you sure you want to save the changes?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                using (var saveContext = new PharmacyDbContext())
                {
                    var account = saveContext.Accounts
                        .Include(acc => acc.Employee)
                        .FirstOrDefault(acc => acc.AccountID == currentAccountId);

                    if (account == null)
                    {
                        XtraMessageBox.Show("Account not found!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    bool usernameExists = saveContext.Accounts
                        .Any(acc => acc.Username == txtUserName.Text.Trim() && acc.AccountID != currentAccountId);

                    if (usernameExists)
                    {
                        XtraMessageBox.Show("Username already exists!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUserName.Focus();
                        return;
                    }

                    account.Username = txtUserName.Text.Trim();
                    account.UserRole = cboRole.SelectedItem.ToString();
                    account.IsActive = chkIsActive.Checked ? "Active" : "Inactive";

                    if (account.Employee != null)
                    {
                        account.Employee.EmployeeName = txtFullName.Text.Trim();
                        account.Employee.Sex = chkFemale.Checked ? "F" : "M";
                        account.Employee.Birthday = dtpBirthday.DateTime;
                        account.Employee.Contact = txtContact.Text.Trim();
                        account.Employee.EmployeeAddress = txtAddress.Text.Trim();
                    }

                    saveContext.SaveChanges();

                    XtraMessageBox.Show("Information updated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadUsersData();
                    ToggleControls(false);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"An error occurred while saving data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            context?.Dispose();
            base.OnFormClosed(e);
        }
    }
}