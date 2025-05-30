using DevExpress.XtraEditors;
using System.Data;
using VitaPharm.Data;
using Microsoft.EntityFrameworkCore;

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
            try
            {
                var categories = context.Categories
                                       .Select(ct => ct.CategoryName)
                                       .ToList();

                cboCategoryName.Properties.Items.Clear();
                cboCategoryName.Properties.Items.AddRange(categories);

                if (cboCategoryName.Properties.Items.Count > 0)
                    cboCategoryName.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error loading categories: {ex.Message}", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtCommdityName.Text))
            {
                XtraMessageBox.Show("Please enter the commodity name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCommdityName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtManufacturer.Text))
            {
                XtraMessageBox.Show("Please enter the manufacturer.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManufacturer.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBaseUnit.Text))
            {
                XtraMessageBox.Show("Please enter the base unit.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBaseUnit.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSellingPrice.Text) ||
                !decimal.TryParse(txtSellingPrice.Text, out decimal sellingPrice) ||
                sellingPrice <= 0)
            {
                XtraMessageBox.Show("Please enter a valid selling price greater than 0.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSellingPrice.Focus();
                return false;
            }

            if (cboCategoryName.SelectedIndex < 0 || string.IsNullOrWhiteSpace(cboCategoryName.Text))
            {
                XtraMessageBox.Show("Please select a category.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCategoryName.Focus();
                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputs())
                    return;

                string selectedCategoryName = cboCategoryName.Text.Trim();
                var category = context.Categories.FirstOrDefault(c => c.CategoryName == selectedCategoryName);

                if (category == null)
                {
                    XtraMessageBox.Show("Selected category not found in database.", "Database Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Commodity newCommodity = new Commodity
                {
                    CommodityName = txtCommdityName.Text.Trim(),
                    Manufacturer = txtManufacturer.Text.Trim(),
                    BaseUnit = txtBaseUnit.Text.Trim(),
                    SellingPrice = decimal.Parse(txtSellingPrice.Text.Trim()),
                    IsTerminated = "active", 
                    Categories = category
                };

                context.Commodities.Add(newCommodity);
                int result = context.SaveChanges();

                if (result > 0)
                {
                    XtraMessageBox.Show("Commodity added successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputs();
                    txtCommdityName.Focus();
                }
                else
                {
                    XtraMessageBox.Show("Failed to save commodity to database.", "Save Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (DbUpdateException dbUpdateEx)
            {
                XtraMessageBox.Show($"Database update error: {dbUpdateEx.InnerException?.Message ?? dbUpdateEx.Message}",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error adding commodity: {ex.Message}\n\nDetails: {ex.InnerException?.Message}",
                    "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            txtCommdityName.Clear();
            txtManufacturer.Clear();
            txtBaseUnit.Clear();
            txtSellingPrice.Clear();

            if (cboCategoryName.Properties.Items.Count > 0)
                cboCategoryName.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Do you want to cancel and reset the form?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClearInputs();
                txtCommdityName.Focus();
            }
        }
    }
}