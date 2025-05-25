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

namespace VitaPharm.Forms
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        private frmProfile? profileForm = null;
        public frmMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void btnProfile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (profileForm == null || profileForm.IsDisposed)
            {
                profileForm = new frmProfile
                {
                    MdiParent = this
                };
            }
            profileForm.Show();
            profileForm.BringToFront();
        }
    }
}