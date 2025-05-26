using DevExpress.XtraEditors;
using VitaPharm.Forms.HumanManage;
using VitaPharm.Data;
using VitaPharm.Forms.Receipt;

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

        internal frmMain(Account account)
        {
            InitializeComponent();
            this.currentAccount = account;
            this.currentRole = account.UserRole ?? "";
            this.IsMdiContainer = true;
            ConfigureBasedOnRole();
            OpenProfile();
            CurrentUser.Username = account.Username;
            CurrentUser.Role = account.UserRole;
            CurrentUser.EmployeeID = account.Employee.EmployeeID;
        }

        #region ConfigureBasedOnRole
        private void ConfigureBasedOnRole()
        {
            bool isAdmin = currentRole.Equals("Admin", StringComparison.OrdinalIgnoreCase);
            bool isUser = currentRole.Equals("User", StringComparison.OrdinalIgnoreCase);

            btnProfile.Enabled = true;
            btnNewUser.Enabled = isAdmin;
            btnAllUsers.Enabled = isAdmin;
            btnAllGoodsReceipt.Enabled = true;
            btnAllCustomers.Enabled = true;
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
            if (!currentRole.Equals("Admin", StringComparison.OrdinalIgnoreCase))
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