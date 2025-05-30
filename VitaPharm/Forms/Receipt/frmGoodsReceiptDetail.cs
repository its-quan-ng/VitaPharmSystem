using System.Data;
using VitaPharm.Data;
using Microsoft.EntityFrameworkCore;

namespace VitaPharm.Forms
{
    public partial class frmGoodsReceiptDetail : DevExpress.XtraEditors.XtraForm
    {
        private PharmacyDbContext context = new PharmacyDbContext();
        private int receiptId;

        public frmGoodsReceiptDetail(int receiptId)
        {
            InitializeComponent();
            this.receiptId = receiptId;
            LoadReceiptDetails();
        }

        private void LoadReceiptDetails()
        {
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
                .ToList();

            gridControl.DataSource = receiptDetails;
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