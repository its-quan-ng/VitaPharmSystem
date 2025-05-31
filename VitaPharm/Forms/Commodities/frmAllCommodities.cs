using DevExpress.XtraEditors;
using Microsoft.EntityFrameworkCore;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using VitaPharm.Data;
using ClosedXML.Excel;
using System.Data;

namespace VitaPharm.Forms.Commodities
{
    public partial class frmAllCommodities : XtraForm
    {
        private PharmacyDbContext context;
        private BindingSource bsCommodities = new BindingSource();
        private getCommodities data;

        public frmAllCommodities()
        {
            InitializeComponent();
            context = new PharmacyDbContext();
            data = new getCommodities(context);
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
            var items = data.GetCommoditiesData();

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

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Import data from Excel file";
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        IXLWorksheet worksheet = workbook.Worksheet(1);
                        bool firstRow = true;
                        string readRange = "1:1";
                        DataTable table = new DataTable();

                        foreach (IXLRow row in worksheet.RowsUsed())
                        {
                            if (firstRow)
                            {
                                readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRange))
                                    table.Columns.Add(cell.Value.ToString());
                                firstRow = false;
                            }
                            else 
                            {
                                table.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    table.Rows[table.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }

                        if (table.Rows.Count > 0)
                        {
                            int successCount = 0;
                            int errorCount = 0;

                            foreach (DataRow r in table.Rows)
                            {
                                try
                                {
                                    string commodityName = r["CommodityName"]?.ToString()?.Trim();
                                    string manufacturer = r["Manufacturer"]?.ToString()?.Trim() ?? "";
                                    string baseUnit = r["BaseUnit"]?.ToString()?.Trim() ?? "";
                                    string sellingPriceStr = r["SellingPrice"]?.ToString()?.Trim();
                                    string status = r["Status"]?.ToString()?.Trim() ?? "active";
                                    string categoryName = r["CategoryName"]?.ToString()?.Trim();

                                    if (string.IsNullOrEmpty(commodityName) || string.IsNullOrEmpty(categoryName))
                                    {
                                        errorCount++;
                                        continue;
                                    }

                                    if (!decimal.TryParse(sellingPriceStr, out decimal sellingPrice))
                                    {
                                        errorCount++;
                                        continue;
                                    }

                                    var category = context.Categories.FirstOrDefault(c => c.CategoryName == categoryName);
                                    if (category == null)
                                    {
                                        errorCount++;
                                        continue;
                                    }

                                    var existingCommodity = context.Commodities
                                        .FirstOrDefault(c => c.CommodityName == commodityName);

                                    if (existingCommodity != null)
                                    {
                                        errorCount++;
                                        continue;
                                    }

                                    var newCommodity = new Commodity
                                    {
                                        CommodityName = commodityName,
                                        Manufacturer = manufacturer,
                                        BaseUnit = baseUnit,
                                        SellingPrice = sellingPrice,
                                        IsTerminated = status,
                                        Categories = category
                                    };
                                    context.Commodities.Add(newCommodity);

                                    successCount++;
                                }
                                catch
                                {
                                    errorCount++;
                                }
                            }

                            context.SaveChanges();
                            XtraMessageBox.Show($"Successfully imported {successCount} rows. Errors: {errorCount} rows.",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmAllCommodities_Load(sender, e);
                        }

                        if (firstRow)
                            XtraMessageBox.Show("Excel file is empty.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Export Commodities to Excel",
                Filter = "Excel Files|*.xlsx",
                FileName = "CMD_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();

                    table.Columns.AddRange(new DataColumn[]
                    {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("CommodityName", typeof(string)),
                        new DataColumn("Manufacturer", typeof(string)),
                        new DataColumn("BaseUnit", typeof(string)),
                        new DataColumn("SellingPrice", typeof(decimal)),
                        new DataColumn("Status", typeof(string)),
                        new DataColumn("CategoryName", typeof(string))
                    });

                    var commodities = data.GetCommoditiesData();

                    foreach (var commodity in commodities)
                    {
                        table.Rows.Add(
                            commodity.ID,
                            commodity.CommodityName,
                            commodity.Manufacturer,
                            commodity.BaseUnit,
                            commodity.SellingPrice,
                            commodity.Status,
                            commodity.CategoryName
                        );
                    }

                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("CMD_" + DateTime.Now.ToString("yyyyMMdd_HHmmss"));
                        worksheet.Cell(1, 1).InsertTable(table);

                        var headerRange = worksheet.Range(1, 1, 1, table.Columns.Count);
                        headerRange.Style.Font.Bold = true;
                        headerRange.Style.Fill.BackgroundColor = XLColor.LightBlue;

                        worksheet.ColumnsUsed().AdjustToContents();

                        var priceColumn = worksheet.Column(5);
                        priceColumn.Style.NumberFormat.Format = "#,##0";

                        workbook.SaveAs(saveFileDialog.FileName);
                    }

                    XtraMessageBox.Show($"Export completed successfully!",
                        "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show($"Error exporting commodities: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
