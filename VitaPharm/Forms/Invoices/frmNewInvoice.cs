using DevExpress.XtraEditors;
using System;
using VitaPharm.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace VitaPharm.Forms.Invoices
{
    public partial class frmNewInvoice : DevExpress.XtraEditors.XtraForm
    {
        private PharmacyDbContext context = new PharmacyDbContext();
        private string currentUser;

        public frmNewInvoice(string username)
        {
            currentUser = username;
            InitializeComponent();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {

        }

        private void frmNewInvoice_Load(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}