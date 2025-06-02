using System.Data;
using VitaPharm.Data;
using DevExpress.XtraEditors;
using System.ComponentModel;
using DevExpress.XtraEditors.Controls;

namespace VitaPharm.Forms.Receipt
{
    public partial class frmNewBatch : XtraForm
    {
        private PharmacyDbContext context = new PharmacyDbContext();
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BatchDto ResultBatch { get; private set; }
        private List<BatchDto> tempBatchList = new List<BatchDto>();

        public frmNewBatch()
        {
            InitializeComponent();
            txtBatchStatus.Properties.ReadOnly = true;
            txtQtyAvailable.Properties.ReadOnly = true;
            lblNewBatchCode.Visible = false;
            cboCommodity.Properties.NullText = "";
            cboBatchCode.Properties.NullText = "";
        }

        private void frmNewBatch_Load(object sender, EventArgs e)
        {
            LoadCommodities();
            ResetForm();
            cboCommodity.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboCommodity.EditValue == null)
            {
                XtraMessageBox.Show("Please select a commodity!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dateExp.DateTime <= dateMfg.DateTime)
            {
                XtraMessageBox.Show("Expiration date must be greater than manufacturing date!");
                return;
            }

            int commodityId = (int)cboCommodity.EditValue;
            var commodity = context.Commodities.Find(commodityId);
            
            ResultBatch = new BatchDto
            {
                CommodityID = commodityId,
                CommodityName = commodity.CommodityName,
                MfgDate = dateMfg.DateTime,
                ExpDate = dateExp.DateTime,
                PurchasePrice = decimal.Parse(txtPurchasePrice.Text),
                Qty = int.TryParse(txtQuantity.Text, out var qty) ? qty : 0
            };

            if (cboBatchCode.EditValue != null)
            {
                int batchId = (int)cboBatchCode.EditValue;
                var batch = context.Batches.Find(batchId);
                ResultBatch.BatchID = batchId;
                ResultBatch.BatchCode = batch.BatchCode;
            }
            else
            {
                ResultBatch.BatchID = 0;
                ResultBatch.BatchCode = GenerateNewBatchCode(commodity.CommodityName);
            }

            DialogResult = DialogResult.OK;
            ResetForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = XtraMessageBox.Show(
                "Are you sure you want to reset the form?", 
                "Confirm Cancel", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ResetForm();
            }
        }

        private void LoadCommodities()
        {
           var commodities = context.Commodities
            .Where(c => c.IsTerminated == "active")
            .ToList();
            cboCommodity.Properties.DataSource = commodities;
            cboCommodity.Properties.DisplayMember = "CommodityName";
            cboCommodity.Properties.ValueMember = "CommodityID";
            cboCommodity.Properties.Columns.Clear();
            
            cboCommodity.Properties.Columns.Add(new LookUpColumnInfo("CommodityName", "Commodity Name"));
            cboCommodity.Properties.Columns.Add(new LookUpColumnInfo("Manufacturer", "Manufacturer"));
            cboCommodity.Properties.Columns.Add(new LookUpColumnInfo("BaseUnit", "Base Unit"));
            cboCommodity.EditValue = null;
        }

        private void cboCommodity_EditValueChanged(object sender, EventArgs e)
        {
            if (cboCommodity.EditValue != null)
            {
                int commodityId = (int)cboCommodity.EditValue;
                var batches = context.Batches
                    .Where(b => b.Commodity.CommodityID == commodityId && b.QtyAvailable > 0 && b.ExpDate > DateTime.Now)
                    .ToList();
                cboBatchCode.Properties.DataSource = batches;
                cboBatchCode.Properties.DisplayMember = "BatchCode";
                cboBatchCode.Properties.ValueMember = "BatchID";
                cboBatchCode.Properties.Columns.Clear();
                cboBatchCode.Properties.Columns.Add(new LookUpColumnInfo("BatchCode", "Batch Code"));
                cboBatchCode.Properties.Columns.Add(new LookUpColumnInfo("ExpDate", "EXP.", 100, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy"));
                cboBatchCode.EditValue = null;

                if (batches.Count == 0)
                {
                    cboBatchCode.Properties.NullText = "No batch available!";
                }
                else
                {
                    cboBatchCode.Properties.NullText = "";
                }
            }
            if (cboBatchCode.EditValue == null && cboCommodity.EditValue != null)
            {
                string commodityName = (context.Commodities.Find((int)cboCommodity.EditValue)).CommodityName;
                lblNewBatchCode.Text = GenerateNewBatchCode(commodityName);
                lblNewBatchCode.Visible = true;
            }
        }

        private void cboBatchCode_EditValueChanged(object sender, EventArgs e)
        {
            if (cboBatchCode.EditValue != null)
            {
                int batchId = (int)cboBatchCode.EditValue;
                var batch = context.Batches.FirstOrDefault(b => b.BatchID == batchId);
                if (batch != null)
                {
                    dateMfg.EditValue = batch.MfgDate;
                    dateExp.EditValue = batch.ExpDate;
                    txtPurchasePrice.Text = batch.PurchasePrice.ToString();
                    txtBatchStatus.Text = batch.BatchStatus;
                    txtQtyAvailable.Text = batch.QtyAvailable.ToString();
                    lblNewBatchCode.Visible = false;
                }
            }
            else
            {
                dateMfg.EditValue = null;
                dateExp.EditValue = null;
                txtPurchasePrice.Text = "";
                txtBatchStatus.Text = "In Stock";
                txtQtyAvailable.Text = "";
                if (cboCommodity.EditValue != null)
                {
                    string commodityName = (context.Commodities.Find((int)cboCommodity.EditValue)).CommodityName;
                    lblNewBatchCode.Text = GenerateNewBatchCode(commodityName);
                    lblNewBatchCode.Visible = true;
                }
                cboBatchCode.Enabled = true;
            }
        }

        private string GenerateNewBatchCode(string commodityName)
        {
            DateTime mfgDate = dateMfg.DateTime == DateTime.MinValue ? DateTime.Now : dateMfg.DateTime;
            string datePart = mfgDate.ToString("yyMMdd");
            int countDb = context.Batches
                .Count(b => b.MfgDate.Date == mfgDate.Date && b.Commodity.CommodityName == commodityName);
            int countTemp = tempBatchList.Count(b => b.MfgDate.Date == mfgDate.Date && b.CommodityName == commodityName);
            int count = countDb + countTemp + 1;
            string countPart = count.ToString("D3");
            return $"BA-{datePart}-{countPart}";
        }

        private void ResetForm()
        {
            cboCommodity.EditValue = null;
            cboBatchCode.Properties.DataSource = null;
            cboBatchCode.EditValue = null;
            dateMfg.EditValue = null;
            dateExp.EditValue = null;
            txtPurchasePrice.Text = "";
            txtBatchStatus.Text = "";
            txtQtyAvailable.Text = "";
            txtQuantity.Text = "1";
            lblNewBatchCode.Visible = false;
            cboBatchCode.Enabled = true;
        }

        private void dateMfg_EditValueChanged(object sender, EventArgs e)
        {
            ShowNewBatchCodeAndDisableBatchCode();
        }
        private void dateExp_EditValueChanged(object sender, EventArgs e)
        {
            ShowNewBatchCodeAndDisableBatchCode();
        }
        private void txtPurchasePrice_EditValueChanged(object sender, EventArgs e)
        {
            ShowNewBatchCodeAndDisableBatchCode();
        }

        private void ShowNewBatchCodeAndDisableBatchCode()
        {
            if (cboCommodity.EditValue != null)
            {
                string commodityName = (context.Commodities.Find((int)cboCommodity.EditValue)).CommodityName;
                lblNewBatchCode.Text = GenerateNewBatchCode(commodityName);
                lblNewBatchCode.Visible = true;
                cboBatchCode.Enabled = false;
            }
        }
    }
}