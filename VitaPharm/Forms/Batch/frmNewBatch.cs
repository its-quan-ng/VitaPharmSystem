using System.Data;
using VitaPharm.Data;
using DevExpress.XtraEditors;

namespace VitaPharm.Forms
{
    public partial class frmNewBatch : DevExpress.XtraEditors.XtraForm
    {
        private PharmacyDbContext context = new PharmacyDbContext();
        public frmNewBatch()
        {
            InitializeComponent();
            txtBatchStatus.Properties.ReadOnly = true;
            txtQtyAvailable.Properties.ReadOnly = true;
            lblNewBatchCode.Visible = false;
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
                }
            }
            else
            {
                dateMfg.EditValue = null;
                dateExp.EditValue = null;
                txtPurchasePrice.Text = "";
                txtBatchStatus.Text = "In Stock";
                txtQtyAvailable.Text = "";
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

    }
}