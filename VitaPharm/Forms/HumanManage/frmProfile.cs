using DevExpress.XtraEditors;
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
            txtEmployeeID.Text = account.Employee.EmployeeID.ToString();
            txtUsername.Text = account.Username;

            txtFullName.Text = account.Employee.EmployeeName;
            ckcFemale.Checked = account.Employee.Sex == "F";
            dateBirthday.DateTime = account.Employee.Birthday;
            txtContact.Text = account.Employee.Contact;
            txtAddress.Text = account.Employee.EmployeeAddress;
            ToggleControl(false);
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

            btnSave.Enabled = !enable;
            btnCancel.Enabled = !enable;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ToggleControl(true);
        }
    }
}