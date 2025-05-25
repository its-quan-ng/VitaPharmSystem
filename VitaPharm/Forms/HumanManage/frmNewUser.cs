using DevExpress.XtraEditors;
using VitaPharm.Data;


namespace VitaPharm.Forms.HumanManage
{
    public partial class frmNewUser : DevExpress.XtraEditors.XtraForm
    {
        private PharmacyDbContext context = new PharmacyDbContext();
        private List<string> roles = new List<string> { "Admin", "User" };

        public frmNewUser()
        {
            InitializeComponent();
        }

        private void ToggleControl(bool enabled)
        {
            txtUsername.Enabled = enabled;
            txtPassword.Enabled = enabled;
            txtConfirmPassword.Enabled = enabled;
            cboRole.Enabled = enabled;
            chkIsActive.Enabled = enabled;
            txtName.Enabled = enabled;
            dtpBirthday.Enabled = enabled;
            chkFemale.Enabled = enabled;
            txtContact.Enabled = enabled;
            txtAddress.Enabled = enabled;
            btnAdd.Enabled = enabled;
            btnCancel.Enabled = enabled;
        }

        private void frmNewUser_Load(object sender, EventArgs e)
        {
            ToggleControl(true);
            cboRole.Properties.Items.Clear();
            cboRole.Properties.Items.AddRange(roles);
            cboRole.SelectedIndex = 1;
            chkIsActive.Checked = true;
            chkFemale.Checked = false;
            dtpBirthday.EditValue = DateTime.Now;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                XtraMessageBox.Show("Please enter a username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                XtraMessageBox.Show("Please enter a password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                XtraMessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmPassword.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                XtraMessageBox.Show("Please enter the full name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }
            if (context.Accounts.Any(a => a.Username == txtUsername.Text))
            {
                XtraMessageBox.Show("Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }
            Employee emp = new Employee
            {
                EmployeeName = txtName.Text,
                Sex = chkFemale.Checked ? "F" : "M",
                Birthday = dtpBirthday.DateTime,
                Contact = txtContact.Text,
                EmployeeAddress = txtAddress.Text
            };
            context.Employees.Add(emp);
            context.SaveChanges();
            // Create Account
            Account acc = new Account
            {
                Username = txtUsername.Text,
                UserPassword = txtPassword.Text,
                UserRole = cboRole.Text,
                IsActive = chkIsActive.Checked ? "Active" : "InActive",
                Employee = emp
            };
            context.Accounts.Add(acc);
            context.SaveChanges();
            XtraMessageBox.Show("New user added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = XtraMessageBox.Show("Do you want to exit this form?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}