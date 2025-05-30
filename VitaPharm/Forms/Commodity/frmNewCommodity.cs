using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VitaPharm.Data;

namespace VitaPharm.Forms.Commodity
{
    public partial class frmNewCommodity : XtraForm
    {
        private PharmacyDbContext context = new PharmacyDbContext();
        private BindingSource bsCommodities = new BindingSource();

        public frmNewCommodity()
        {
            InitializeComponent();
            txtCommdityName.Focus();
        }

        private void frmNewCommodity_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            var types = context.Categories
                               .Select(ct => ct.CategoryName)
                               .ToList();

            cboCategoryName.Properties.Items.Clear();
            cboCategoryName.Properties.Items.AddRange(types);
            cboCategoryName.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCommdityName.Text))
            {
                XtraMessageBox.Show("Please enter the commodity name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCommdityName.Focus();
                return;
            }
        }
    }
}