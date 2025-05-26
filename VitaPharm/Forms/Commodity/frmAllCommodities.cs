using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using Microsoft.EntityFrameworkCore;
using VitaPharm.Data;

namespace VitaPharm.Forms.Commodity
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
            cboCategoryName.EditValue = null;
        }

        private void LoadCommodities()
        {
            var commodities = context.Commodities
                                     .Include(c => c.Categories)
                                     .Select(c => new
                                     {
                                         c.CommodityName,
                                         c.Manufacturer,
                                         c.BaseUnit,
                                         c.SellingPrice,
                                         Status = c.IsTerminated,
                                         c.Categories.CategoryName
                                     }).AsEnumerable()
                                    .Select((x, idx) => new
                                    {
                                        ID = idx + 1,                           
                                        x.CommodityName,
                                        x.Manufacturer,
                                        x.BaseUnit,
                                        x.SellingPrice,
                                        x.Status,
                                        x.CategoryName
                                    })
                                    .ToList();

            bsCommodities.DataSource = commodities;
            gridControl.DataSource = bsCommodities;

            gridView.PopulateColumns();
            gridView.BestFitColumns();
        }

        private void gridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            var row = gridView.GetRow(e.FocusedRowHandle) as dynamic;
            if (row == null) return;

            txtCommodityName.EditValue = row.CommodityName;
            txtManufacturer.EditValue = row.Manufacturer;
            txtBaseUnit.EditValue = row.BaseUnit;
            txtSellingPrice.EditValue = row.SellingPrice;
            txtIsTerminated.EditValue = row.Status;
            cboCategoryName.EditValue = row.CategoryName;
        }

        private void ToggleControls(bool enable)
        {
            txtCommodityName.Enabled = enable;
            txtManufacturer.Enabled = enable;
            txtBaseUnit.Enabled = enable;
            txtSellingPrice.Enabled = enable;
            txtIsTerminated.Enabled = enable;
            cboCategoryName.Enabled = enable;

            btnSave.Enabled = enable;
            btnCancel.Enabled = enable;
            btnEdit.Enabled = !enable;
            btnReload.Enabled = !enable;
        }
    }
}
