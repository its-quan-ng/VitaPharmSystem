using DevExpress.XtraEditors;
using System.Data;
using VitaPharm.Data;

namespace VitaPharm.Forms.Commodities
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

        private void ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtCommdityName.Text))
            {
                XtraMessageBox.Show("Please enter the commodity name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCommdityName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtManufacturer.Text))
            {
                XtraMessageBox.Show("Please enter the manufacturer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtManufacturer.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtBaseUnit.Text))
            {
                XtraMessageBox.Show("Please enter the base unit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBaseUnit.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSellingPrice.Text) || !decimal.TryParse(txtSellingPrice.Text, out decimal sellingPrice) || sellingPrice <= 0)
            {
                XtraMessageBox.Show("Please enter a valid selling price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSellingPrice.Focus();
                return;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ValidateInputs();

            string catName = cboCategoryName.Text;
            var category = context.Categories.FirstOrDefault(c => c.CategoryName == catName);
            if (category == null)
            {
                XtraMessageBox.Show("Selected category not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Commodity newCommodity = new Commodity
            {
                CommodityName = txtCommdityName.Text.Trim(),
                Manufacturer = txtManufacturer.Text.Trim(),
                BaseUnit = txtBaseUnit.Text.Trim(),
                SellingPrice = txtSellingPrice.Text.Trim() != "" ? decimal.Parse(txtSellingPrice.Text.Trim()) : 0,
                Categories = category
            };
            context.Commodities.Add(newCommodity);
            context.SaveChanges();
            XtraMessageBox.Show("Commodity added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtCommdityName.Clear();
            txtManufacturer.Clear();
            txtBaseUnit.Clear();
            txtSellingPrice.Clear();
            cboCategoryName.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Do you want to cancel and reset the form?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClearInputs();
            }
        }
    }
}