using System.Data;
using VitaPharm.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace VitaPharm.Forms
{
    public partial class frmGoodsReceiptDetail : DevExpress.XtraEditors.XtraForm
    {
        private PharmacyDbContext context = new PharmacyDbContext();
        private int receiptId;
        private BindingSource bsReceiptDetails = new BindingSource();

        public frmGoodsReceiptDetail(int receiptId)
        {
            InitializeComponent();
            this.receiptId = receiptId;
            LoadReceiptDetails();
        }

        private void LoadReceiptDetails()
        {
            try
            {
                context?.Dispose();
                context = new PharmacyDbContext();

                var receiptDetails = context.GoodsReceiptDetails
                    .Include(d => d.Batch)
                    .Include(d => d.Batch.Commodity)
                    .Where(d => d.GoodsReceipt.ReceiptID == receiptId)
                    .Select(d => new
                    {
                        d.Batch.BatchCode,
                        d.Batch.Commodity.CommodityName,
                        d.Batch.MfgDate,
                        d.Batch.ExpDate,
                        d.Batch.PurchasePrice,
                        Quantity = d.QtyIn,
                        Amount = d.QtyIn * d.Batch.PurchasePrice
                    })
                    .AsEnumerable()
                    .Select((x, idx) => new
                    {
                        ID = idx + 1,
                        x.BatchCode,
                        x.CommodityName,
                        x.MfgDate,
                        x.ExpDate,
                        x.PurchasePrice,
                        x.Quantity,
                        x.Amount
                    })
                    .ToList();

                bsReceiptDetails.DataSource = receiptDetails;
                gridControl.DataSource = bsReceiptDetails;
                SetupDataBindings();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error loading receipt details: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupDataBindings()
        {
            txtBatchCode.DataBindings.Clear();
            txtCommodityName.DataBindings.Clear();
            dateMfg.DataBindings.Clear();
            dateExp.DataBindings.Clear();
            txtPurchasePrice.DataBindings.Clear();
            txtQuantity.DataBindings.Clear();
            txtAmount.DataBindings.Clear();

            txtBatchCode.DataBindings.Add(
                "Text", bsReceiptDetails, "BatchCode",
                true, DataSourceUpdateMode.Never);

            txtCommodityName.DataBindings.Add(
                "Text", bsReceiptDetails, "CommodityName",
                true, DataSourceUpdateMode.Never);

            dateMfg.DataBindings.Add(
                "DateTime", bsReceiptDetails, "MfgDate",
                true, DataSourceUpdateMode.Never);

            dateExp.DataBindings.Add(
                "DateTime", bsReceiptDetails, "ExpDate",
                true, DataSourceUpdateMode.Never);

            txtPurchasePrice.DataBindings.Add(
                "Text", bsReceiptDetails, "PurchasePrice",
                true, DataSourceUpdateMode.Never);

            txtQuantity.DataBindings.Add(
                "Text", bsReceiptDetails, "Quantity",
                true, DataSourceUpdateMode.Never);

            txtAmount.DataBindings.Add(
                "Text", bsReceiptDetails, "Amount",
                true, DataSourceUpdateMode.Never);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadReceiptDetails();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}