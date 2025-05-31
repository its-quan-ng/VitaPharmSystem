using System.Data;
using VitaPharm.Data;
using Microsoft.EntityFrameworkCore;
using DevExpress.XtraEditors;

namespace VitaPharm.Forms
{
    public partial class frmGoodsReceiptDetail : XtraForm
    {
        private PharmacyDbContext context = new PharmacyDbContext();
        private int receiptId;

        public frmGoodsReceiptDetail(int receiptId)
        {
            InitializeComponent();
            this.receiptId = receiptId;
            LoadReceiptInfo();
            LoadReceiptDetails();
            ToggleControls();
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
                    .ToList();

                gridControl.DataSource = receiptDetails;

                var totalQuantity = receiptDetails.Sum(d => d.Quantity);
                var totalAmount = receiptDetails.Sum(d => d.Amount);

                lblTotalQuantity.Text = totalQuantity.ToString("N0");
                lblTotalAmount.Text = totalAmount.ToString("N0") + " VND";
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error loading receipt details: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToggleControls()
        {
            txtReceiptCode.Enabled = false;
            txtEmployee.Enabled = false;
            dateReceiptDate.Enabled = false;
            txtSupplier.Enabled = false;
            txtNote.Enabled = false;
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
            var result = XtraMessageBox.Show("Are you sure you want to cancel?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void LoadReceiptInfo()
        {
            var receipt = context.GoodsReceipts
                .Include(r => r.Employee)
                .FirstOrDefault(r => r.ReceiptID == receiptId);

            if (receipt != null)
            {
                txtReceiptCode.Text = receipt.ReceiptCode;
                dateReceiptDate.DateTime = receipt.ReceiptDate;
                txtSupplier.Text = receipt.SupplierName;
                txtNote.Text = receipt.Note;
                txtEmployee.Text = receipt.Employee?.EmployeeName ?? "";
            }
        }
    }
}