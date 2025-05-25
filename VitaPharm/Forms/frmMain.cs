using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using VitaPharm.Forms.HumanManage;
using VitaPharm.Data;

namespace VitaPharm.Forms
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        private readonly Account currentAccount;
        private frmProfile? profileForm = null;

        internal frmMain(Account account)
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            currentAccount = account;
        }

        private void btnProfile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (profileForm == null || profileForm.IsDisposed)
            {
                profileForm = new frmProfile(currentAccount)
                {
                    MdiParent = this
                };
            }
            profileForm.Show();
            profileForm.BringToFront();
        }
    }
}