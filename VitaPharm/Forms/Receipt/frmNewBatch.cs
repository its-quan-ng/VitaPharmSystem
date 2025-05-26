using System.Data;
using VitaPharm.Data;
using DevExpress.XtraEditors;

namespace VitaPharm.Forms.Receipt
{
    public partial class frmNewBatch : XtraForm
    {
        private PharmacyDbContext context = new PharmacyDbContext();
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
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboCommodity.EditValue == null)
            {
                XtraMessageBox.Show("Please select a commodity!");
                return;
            }
            if (dateExp.DateTime <= dateMfg.DateTime)
            {
                XtraMessageBox.Show("Expiration date must be greater than manufacturing date!");
                return;
            }
            int quantity = (int)spinQuantity.Value;
            int commodityId = (int)cboCommodity.EditValue;

            if (cboBatchCode.EditValue != null)
            {
                int batchId = (int)cboBatchCode.EditValue;
                var batch = context.Batches.Find(batchId);
                batch.QtyAvailable += quantity;
            }
            else
            {
                string commodityName = (context.Commodities.Find(commodityId)).CommodityName;
                string batchCode = GenerateNewBatchCode(commodityName);
                var newBatch = new Batch
                {
                    BatchCode = batchCode,
                    MfgDate = dateMfg.DateTime,
                    ExpDate = dateExp.DateTime,
                    PurchasePrice = decimal.Parse(txtPurchasePrice.Text),
                    QtyAvailable = quantity,
                    BatchStatus = "In stock",
                    Commodity = context.Commodities.Find(commodityId)
                };
                context.Batches.Add(newBatch);
            }
            context.SaveChanges();
            XtraMessageBox.Show("Batch added successfully!");
            frmNewBatch_Load(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = XtraMessageBox.Show("Do you want to cancel and reset the form?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ResetForm();
            }
        }

        private void LoadCommodities()
        {
            var commodities = context.Commodities.ToList();
            cboCommodity.Properties.DataSource = commodities;
            cboCommodity.Properties.DisplayMember = "CommodityName";
            cboCommodity.Properties.ValueMember = "CommodityID";
            cboCommodity.EditValue = null;
        }

        private void cboCommodity_EditValueChanged(object sender, EventArgs e)
        {
            if (cboCommodity.EditValue != null)
            {
                int commodityId = (int)cboCommodity.EditValue;
                var batches = context.Batches
                    .Where(b => b.Commodity.CommodityID == commodityId && b.QtyAvailable > 0)
                    .ToList();
                cboBatchCode.Properties.DataSource = batches;
                cboBatchCode.Properties.DisplayMember = "BatchCode";
                cboBatchCode.Properties.ValueMember = "BatchID";
                cboBatchCode.EditValue = null;
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
            string prefix = "BA";
            string namePart = new string(commodityName
                .Take(7)
                .Select(c => c == ' ' ? '-' : c)
                .ToArray());
            string datePart = DateTime.Now.ToString("ddMMyy");
            int count = context.Batches
                .Count(b => b.MfgDate.Date == DateTime.Now.Date && b.Commodity.CommodityName == commodityName) + 1;
            string countPart = count.ToString("D2");
            return $"{prefix}-{namePart}-{datePart}-{countPart}";
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
            spinQuantity.Value = 1;
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