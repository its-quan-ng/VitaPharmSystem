using DevExpress.XtraEditors;
using Microsoft.EntityFrameworkCore;
using VitaPharm.Data;

namespace VitaPharm.Forms.HumanManage
{
    public partial class frmProfile : XtraForm
    {
        private readonly Account account;
        internal frmProfile(Account account)
        {
            InitializeComponent();
            this.account = account;
        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            LoadProfileData();
            ToggleControl(false);
        }

        private void LoadProfileData()
        {
            txtEmployeeID.Text = account.Employee.EmployeeID.ToString();
            txtUsername.Text = account.Username;
            txtFullName.Text = account.Employee.EmployeeName;
            ckcFemale.Checked = account.Employee.Sex == "F";
            dateBirthday.DateTime = account.Employee.Birthday;
            txtContact.Text = account.Employee.Contact;
            txtAddress.Text = account.Employee.EmployeeAddress;
        }

        private void ToggleControl(bool enable)
        {
            txtEmployeeID.Enabled = false;

            txtUsername.Enabled = enable;
            txtFullName.Enabled = enable;
            ckcFemale.Enabled = enable;
            dateBirthday.Enabled = enable;
            txtContact.Enabled = enable;
            txtAddress.Enabled = enable;

            btnEdit.Enabled = !enable;
            btnSave.Enabled = enable;
            btnCancel.Enabled = enable;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ToggleControl(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using var ctx = new PharmacyDbContext();  
            var acct = ctx.Accounts
                         .Include(a => a.Employee)
                         .FirstOrDefault(a => a.AccountID == account.AccountID);
            if (acct == null) return;

            acct.Username = txtUsername.Text.Trim();
            acct.Employee.EmployeeName = txtFullName.Text.Trim();
            acct.Employee.Sex = ckcFemale.Checked ? "F" : "M";
            acct.Employee.Birthday = dateBirthday.DateTime;
            acct.Employee.Contact = txtContact.Text.Trim();
            acct.Employee.EmployeeAddress = txtAddress.Text.Trim();

            ctx.SaveChanges();

            XtraMessageBox.Show(
                "Profile updated successfully.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            LoadProfileData();
            ToggleControl(false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(
                "Discard changes and reload original data?",
                "Confirm Cancel",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoadProfileData();
                ToggleControl(false);
            }
        }
    }
}