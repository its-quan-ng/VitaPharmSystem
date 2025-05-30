using DevExpress.XtraEditors;
using Microsoft.EntityFrameworkCore;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using VitaPharm.Data;

namespace VitaPharm.Forms.Commodities
{
    public partial class frmAllCommodities : XtraForm
    {
        private PharmacyDbContext context;
        private BindingSource bsCommodities = new BindingSource();

        public frmAllCommodities()
        {
            InitializeComponent();
            context = new PharmacyDbContext();
        }

        private void frmAllCommodities_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadStatus();
            LoadCommodities();
            ToggleControls(false);
        }

        private void LoadCategories()
        {
            var types = context.Categories
                               .Select(ct => ct.CategoryName)
                               .ToList();

            cboCategoryName.Properties.Items.Clear();
            cboCategoryName.Properties.Items.AddRange(types);
        }

        private void LoadStatus()
        {
            cboIsTerminated.Properties.Items.Clear();
            cboIsTerminated.Properties.Items.AddRange(new[] { "active", "inactive" });
        }

        private void LoadCommodities()
        {
            var items = context.Commodities
                               .Include(c => c.Categories)
                               .AsEnumerable()
                               .Select((c, idx) => new
                               {
                                   ID = idx + 1,                 
                                   c.CommodityID,                          
                                   c.CommodityName,
                                   c.Manufacturer,
                                   c.BaseUnit,
                                   c.SellingPrice,
                                   Status = c.IsTerminated,
                                   CategoryName = c.Categories?.CategoryName
                               })
                               .ToList();

            bsCommodities.DataSource = items;
            gridControl.DataSource = bsCommodities;

            gridView.PopulateColumns();
            HideColumnSafely(gridView, "CommodityID");
            gridView.Columns["SellingPrice"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView.Columns["SellingPrice"].DisplayFormat.FormatString = "N0";
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsView.ShowGroupPanel = false;
            gridView.BestFitColumns();
        }

        private static void HideColumnSafely(GridView view, string fieldName)
        {
            var col = view.Columns[fieldName];
            if (col != null)
            {
                col.Visible = false;
                col.OptionsColumn.ShowInCustomizationForm = false;
            }
        }

        private void ToggleControls(bool enable)
        {
            txtCommodityName.Enabled = enable;
            txtManufacturer.Enabled = enable;
            txtBaseUnit.Enabled = enable;
            txtSellingPrice.Enabled = enable;
            cboIsTerminated.Enabled = enable;
            cboCategoryName.Enabled = enable;

            btnSave.Enabled = enable;
            btnCancel.Enabled = enable;
            btnEdit.Enabled = !enable;
            btnReload.Enabled = true;
        }

        private void gridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            var row = gridView.GetRow(e.FocusedRowHandle) as dynamic;
            if (row == null)
            {
                ToggleControls(false);
                this.Tag = null;
                return;
            }

            txtCommodityName.EditValue = row.CommodityName;
            txtManufacturer.EditValue = row.Manufacturer;
            txtBaseUnit.EditValue = row.BaseUnit;
            txtSellingPrice.EditValue = row.SellingPrice;
            cboIsTerminated.EditValue = row.Status;
            cboCategoryName.EditValue = row.CategoryName;

            this.Tag = row.CommodityID;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.Tag == null)
            {
                XtraMessageBox.Show("Please select a commodity.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ToggleControls(true);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadCategories();
            LoadStatus();
            LoadCommodities();
            ToggleControls(false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Do you want to discard your changes?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnReload_Click(sender, e);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.Tag == null)
                return;

            if (string.IsNullOrWhiteSpace(txtCommodityName.Text))
            {
                XtraMessageBox.Show("Commodity Name cannot be empty.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCommodityName.Focus();
                return;
            }
            if (!decimal.TryParse(txtSellingPrice.Text, out var price) || price < 0)
            {
                XtraMessageBox.Show("Enter a valid selling price.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSellingPrice.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cboCategoryName.Text))
            {
                XtraMessageBox.Show("Select a category.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCategoryName.Focus();
                return;
            }

            var confirm = XtraMessageBox.Show("Save changes to this commodity?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            int id = Convert.ToInt32(this.Tag);
            try
            {
                var commodity = context.Commodities
                                       .Include(c => c.Categories)
                                       .FirstOrDefault(c => c.CommodityID == id);
                if (commodity == null)
                {
                    XtraMessageBox.Show("Commodity not found.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                commodity.CommodityName = txtCommodityName.Text.Trim();
                commodity.Manufacturer = txtManufacturer.Text.Trim();
                commodity.BaseUnit = txtBaseUnit.Text.Trim();
                commodity.SellingPrice = price;
                commodity.IsTerminated = cboIsTerminated.Text.Trim();

                var selectedCat = context.Categories
                                         .FirstOrDefault(c => c.CategoryName == cboCategoryName.Text.Trim());
                if (selectedCat != null)
                    commodity.Categories = selectedCat;

                var changes = context.SaveChanges();
                if (changes > 0)
                {
                    XtraMessageBox.Show("Save successful.", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("No changes detected.", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error saving commodity: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmAllCommodities_Load(sender, e); 
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            context?.Dispose();
            base.OnFormClosed(e);
        }
    }
}
