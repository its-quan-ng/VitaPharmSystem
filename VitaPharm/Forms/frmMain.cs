using DevExpress.XtraEditors;
using VitaPharm.Forms.HumanManage;
using VitaPharm.Data;

namespace VitaPharm.Forms
{
    public partial class frmMain : XtraForm
    {
        private readonly Account currentAccount;
        private readonly string currentRole;
        private frmProfile? profileForm = null;
        frmNewUser? newUserForm = null;

        internal frmMain(Account account)
        {
            InitializeComponent();
            this.currentAccount = account;
            this.currentRole = account.UserRole ?? "";
            this.IsMdiContainer = true;
            ConfigureBasedOnRole();
            OpenProfile();
        }

        #region ConfigureBasedOnRole
        private void ConfigureBasedOnRole()
        {
            bool isAdmin = currentRole.Equals("Admin", StringComparison.OrdinalIgnoreCase);
            bool isUser = currentRole.Equals("User", StringComparison.OrdinalIgnoreCase);

            btnProfile.Enabled = true;
            btnNewUser.Enabled = isAdmin;
        }

        private void OpenProfile()
        {
            foreach (var f in this.MdiChildren) f.Close();
            var profileForm = new frmProfile(currentAccount)
            {
                MdiParent = this
            };
            profileForm.Show();
        }

        private void OpenNewUser()
        {
            if (!currentRole.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                XtraMessageBox.Show("You do not have permission to access this feature!","Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var f in this.MdiChildren) f.Close();

            if (newUserForm == null || newUserForm.IsDisposed)
            {
                newUserForm = new frmNewUser()
                {
                    MdiParent = this
                };
            }
            newUserForm.Show();
            newUserForm.BringToFront();
        }
        #endregion

        private void btnProfile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenProfile();
        }

        private void btnNewUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenNewUser();
        }
    }
}