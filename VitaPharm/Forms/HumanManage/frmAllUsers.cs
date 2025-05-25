using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using Microsoft.EntityFrameworkCore;
using VitaPharm.Data;

namespace VitaPharm.Forms.HumanManage
{
    public partial class frmAllUsers : XtraForm
    {
        private PharmacyDbContext context;

        public frmAllUsers()
        {
            InitializeComponent();
        }

        private void frmAllUsers_Load(object sender, EventArgs e)
        {
            LoadUsersData();
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
                    acc.UserPassword
                })
                .ToList();

            gridControl.DataSource = users;
        }

        private void GridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            var row = gridView.GetRow(e.FocusedRowHandle) as dynamic;
            if (row == null) return;

            txtUserName.Text = row.Username;
            txtFullName.Text = row.EmployeeName;
            chkFemale.Checked = (row.Sex == "F");
            dtpBirthday.DateTime = (DateTime)row.Birthday;
            txtContact.Text = row.Contact;
            txtAddress.Text = row.EmployeeAddress;
            cboRole.SelectedItem = row.UserRole;
            chkIsActive.Checked = (row.IsActive == "Active");
        }
    }
}
