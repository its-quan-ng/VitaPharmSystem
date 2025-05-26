using DevExpress.XtraEditors;
using Microsoft.EntityFrameworkCore;
using VitaPharm.Data;

namespace VitaPharm.Forms
{
    public partial class frmSignIn : XtraForm
    {
        public frmSignIn()
        {
            InitializeComponent();
            txtUsername.Focus();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (HandleEmptyInput(username, password)) return;

            using var context = new PharmacyDbContext();
            var account = context.Accounts
                .Include(a => a.Employee)
                .FirstOrDefault(a => a.Username == username);

            if (account != null)
            {
                if (HandlePasswordMismatch(account, password)) return;
                LoginSuccess(account);
            }
            else
            {
                XtraMessageBox.Show(
                    "Username not found.",
                    "Login Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        #region Handle case sign in
        private bool HandleEmptyInput(string username, string password)
        {
            bool isUsernameEmpty = string.IsNullOrWhiteSpace(username);
            bool isPasswordEmpty = string.IsNullOrWhiteSpace(password);

            if (isUsernameEmpty && isPasswordEmpty)
            {
                XtraMessageBox.Show(
                    "Please enter username and password.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtUsername.Focus();
                return true;
            }

            if (isUsernameEmpty)
            {
                XtraMessageBox.Show(
                    "Please enter your username.",
                    "Missing Username",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtUsername.Focus();
                return true;
            }

            if (isPasswordEmpty)
            {
                XtraMessageBox.Show(
                    "Please enter your password.",
                    "Missing Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtPassword.Focus();
                return true;
            }

            return false;
        }

        private bool HandlePasswordMismatch(Account account, string password)
        {
            if (!account.UserPassword.Equals(password, StringComparison.Ordinal))
            {
                XtraMessageBox.Show(
                    "Incorrect password.",
                    "Login Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
                return true;
            }
            return false;
        }

        private void LoginSuccess(Account account)
        {
            CurrentUser.Username = account.Username;
            CurrentUser.Role = account.UserRole;
            CurrentUser.EmployeeID = account.Employee.EmployeeID;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        #endregion

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSignIn_Click(sender, e);
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSignIn_Click(sender, e);
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            var result = XtraMessageBox.Show(
                "Are you sure you want to exit?",
                "Exit Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = chkShowPassword.Checked;
        }
    }
}