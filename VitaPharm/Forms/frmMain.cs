using DevExpress.XtraEditors;
using VitaPharm.Forms.HumanManage;
using VitaPharm.Data;

namespace VitaPharm.Forms
{
    public partial class frmMain : XtraForm
    {
        #region Global variable
        private readonly Account currentAccount;
        private readonly string currentRole;
        private frmProfile? profileForm = null;
        private frmNewUser? newUserForm = null;
        private frmAllGoodsReceipt? allGoodsReceiptForm = null;
        private frmAllUsers? allUsersForm = null;
        private frmAllCustomers? allCustomersForm = null;
        #endregion

        public frmMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            ShowSignIn();
        }

        private void ShowSignIn()
        {
            var signIn = new frmSignIn();
            if (signIn.ShowDialog() == DialogResult.OK)
            {
                XtraMessageBox.Show(
                    "Login successful!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                ConfigureBasedOnRole();
                OpenProfile();
            }
            else
            {
                this.Close();
            }
            signIn.Dispose();
        }

        private void SignOut()
        {
            CurrentUser.Username = null;
            CurrentUser.Role = null;
            CurrentUser.EmployeeID = 0;
            foreach (var f in this.MdiChildren) f.Close();
            ShowSignIn();
        }

        #region ConfigureBasedOnRole
        private void ConfigureBasedOnRole()
        {
            bool isAdmin = CurrentUser.Role.Equals("Admin", StringComparison.OrdinalIgnoreCase);
            bool isUser = CurrentUser.Role.Equals("User", StringComparison.OrdinalIgnoreCase);

            btnProfile.Enabled = true;
            btnNewUser.Enabled = isAdmin;
            btnAllUsers.Enabled = isAdmin;
            btnAllGoodsReceipt.Enabled = true;
            btnAllCustomers.Enabled = true;
        }

        private void OpenProfile()
        {
            foreach (var f in this.MdiChildren) f.Close();
            var profileForm = new frmProfile(CurrentUser.EmployeeID)
            {
                MdiParent = this
            };
            profileForm.Show();
        }

        private void OpenNewUser()
        {
            if (!CurrentUser.Role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                XtraMessageBox.Show("You do not have permission to access this feature!", "Notification",
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

        private void OpenAllGoodsReceipt()
        {
            foreach (var f in this.MdiChildren) f.Close();
            if (allGoodsReceiptForm == null || allGoodsReceiptForm.IsDisposed)
            {
                allGoodsReceiptForm = new frmAllGoodsReceipt()
                {
                    MdiParent = this
                };
            }
            allGoodsReceiptForm.Show();
            allGoodsReceiptForm.BringToFront();
        }

        private void OpenAllUsers()
        {
            if (!CurrentUser.Role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                XtraMessageBox.Show("You do not have permission to access this feature!", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var f in this.MdiChildren) f.Close();

            if (allUsersForm == null || allUsersForm.IsDisposed)
            {
                allUsersForm = new frmAllUsers()
                {
                    MdiParent = this
                };
            }
            allUsersForm.Show();
            allUsersForm.BringToFront();
        }

        private void OpenAllCustomers()
        {
            foreach (var f in this.MdiChildren) f.Close();
            if (allCustomersForm == null || allCustomersForm.IsDisposed)
            {
                allCustomersForm = new frmAllCustomers()
                {
                    MdiParent = this
                };
            }
            allCustomersForm.Show();
            allCustomersForm.BringToFront();
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

        private void btnAllGoodsReceipt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenAllGoodsReceipt();
        }

        private void btnAllUsers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenAllUsers();
        }

        private void btnAllCustomers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenAllCustomers();
        }

        private void btnSignOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var result = XtraMessageBox.Show("Are you sure you want to sign out?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            foreach (var child in this.MdiChildren)
                child.Close();

            this.Hide();

            using (var signInForm = new frmSignIn())
            {
                var dialogResult = signInForm.ShowDialog();
                /*if (dialogResult == DialogResult.OK &&
                    !string.IsNullOrEmpty(signInForm.CurrentUser.Username))
                {
                    var newMain = new frmMain(signInForm.CurrentUser);
                    newMain.Show();
                }
                else
                {
                    Application.Exit();
                }*/
            }
            this.Close();
        }
    }
}