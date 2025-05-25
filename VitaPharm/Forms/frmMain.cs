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

        internal frmMain(Account account)
        {
            InitializeComponent();
            this.currentAccount = account;
            this.currentRole = account.UserRole ?? "";
            this.IsMdiContainer = true;

            ConfigureBasedOnRole();
            OpenProfile();
        }

        #region Handle Sign In
        private void ConfigureBasedOnRole()
        {
            bool isAdmin = currentRole.Equals("Admin", StringComparison.OrdinalIgnoreCase);
            bool isUser = currentRole.Equals("User", StringComparison.OrdinalIgnoreCase);

            btnProfile.Enabled = true;
            
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
        #endregion

        private void btnProfile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenProfile();
        }
    }
}