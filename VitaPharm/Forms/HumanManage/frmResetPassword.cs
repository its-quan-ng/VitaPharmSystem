using DevExpress.XtraEditors;
using VitaPharm.Data;

namespace VitaPharm.Forms.HumanManage
{
    public partial class frmResetPassword : DevExpress.XtraEditors.XtraForm
    {
        private int accountId;
        private bool isNewPasswordVisible = false;
        private bool isConfirmPasswordVisible = false;

        public frmResetPassword(int accountId, string username, string fullName)
        {
            InitializeComponent();
            this.accountId = accountId;
            textUsername.Text = username;
            txtFullName.Text = fullName;
            textUsername.Properties.ReadOnly = true;
            txtFullName.Properties.ReadOnly = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmNewPassword.Text;

            if (string.IsNullOrWhiteSpace(newPassword))
            {
                XtraMessageBox.Show("Please enter a new password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return;
            }
            if (newPassword != confirmPassword)
            {
                XtraMessageBox.Show("Passwords do not match.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmNewPassword.Focus();
                return;
            }

            using (var context = new PharmacyDbContext())
            {
                var account = context.Accounts.FirstOrDefault(a => a.AccountID == accountId);
                if (account == null)
                {
                    XtraMessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                account.UserPassword = newPassword;
                context.SaveChanges();
            }
            XtraMessageBox.Show("Password reset successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
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
                frmResetPassword_Load(sender, e);
            }
        }

        private void frmResetPassword_Load(object sender, EventArgs e)
        {
            txtNewPassword.Text = string.Empty;
            txtConfirmNewPassword.Text = string.Empty;
            txtNewPassword.Focus();
        }

        private void btnEye_Click(object sender, EventArgs e)
        {
            isNewPasswordVisible = !isNewPasswordVisible;
            txtNewPassword.Properties.PasswordChar = isNewPasswordVisible ? '\0' : '●';
        }

        private void btnEyeConfirm_Click(object sender, EventArgs e)
        {
            isConfirmPasswordVisible = !isConfirmPasswordVisible;
            txtConfirmNewPassword.Properties.PasswordChar = isConfirmPasswordVisible ? '\0' : '●';
        }
    }
}