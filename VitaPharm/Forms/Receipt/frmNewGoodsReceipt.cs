using System.ComponentModel;
using DevExpress.XtraEditors;
using VitaPharm.Data;

namespace VitaPharm.Forms.Receipt
{
    public partial class frmNewGoodsReceipt : DevExpress.XtraEditors.XtraForm
    {
        private PharmacyDbContext context = new PharmacyDbContext();
        private BindingList<BatchDto> detailsList = new();
        private string currentUser;

        public frmNewGoodsReceipt(string username)
        {
            InitializeComponent();
            currentUser = username;
            repobtnDelete.ButtonClick += RepoBtnDelete_ButtonClick;
            gridControl.DataSource = detailsList;
            InitializeForm();
        }

        private void InitializeForm()
        {
            dateReceiptDate.DateTime = DateTime.Now;
            txtReceiptCode.Text = GenerateReceiptCode();

            var account = context.Accounts.FirstOrDefault(a => a.Username == currentUser);
            if (account != null)
            {
                txtEmployee.Text = account.Employee.EmployeeName;
                txtEmployee.Properties.ReadOnly = true;
            }
        }

        private string GenerateReceiptCode()
        {
            string prefix = "PN";
            string datePart = DateTime.Now.ToString("yyMMdd");
            int count = context.GoodsReceipts
                .Count(r => r.ReceiptDate.Date == DateTime.Now.Date) + 1;
            string countPart = count.ToString("D3");
            return $"{prefix}{datePart}{countPart}";
        }

        private void btnAddBatch_Click(object sender, EventArgs e)
        {
            using var dlg = new frmNewBatch();
            if (dlg.ShowDialog() == DialogResult.OK && dlg.ResultBatch != null)
            {
                detailsList.Add(dlg.ResultBatch);
                RecalcSummary();
            }
        }

        private void RecalcSummary()
        {
            decimal total = detailsList.Sum(d => d.Qty * d.PurchasePrice);
            lblTotal.Text = total.ToString("N2");
        }

        private void RepoBtnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var dto = gridView.GetFocusedRow() as BatchDto;
            if (dto == null) return;

            if (XtraMessageBox.Show("Remove this batch?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            detailsList.Remove(dto);
            RecalcSummary();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSupplier.Text))
            {
                XtraMessageBox.Show("Please enter supplier name!");
                return;
            }

            if (detailsList.Count == 0)
            {
                XtraMessageBox.Show("Please add at least one batch!");
                return;
            }

            using var transaction = context.Database.BeginTransaction();
            try
            {
                var receipt = new GoodsReceipt
                {
                    ReceiptCode = txtReceiptCode.Text,
                    ReceiptDate = dateReceiptDate.DateTime,
                    SupplierName = txtSupplier.Text,
                    Note = meNote.Text,
                    ReceiptStatus = "Success",
                    Employee = context.Accounts.First(a => a.Username == currentUser).Employee
                };
                context.GoodsReceipts.Add(receipt);
                context.SaveChanges();

                foreach (var dto in detailsList)
                {
                    Batch batch;
                    if (dto.BatchID == 0)
                    {
                        batch = new Batch
                        {
                            BatchCode = dto.BatchCode,
                            MfgDate = dto.MfgDate,
                            ExpDate = dto.ExpDate,
                            PurchasePrice = dto.PurchasePrice,
                            QtyAvailable = dto.Qty,
                            BatchStatus = "In stock",
                            Commodity = context.Commodities.Find(dto.CommodityID)
                        };
                        context.Batches.Add(batch);
                    }
                    else
                    {
                        batch = context.Batches.Find(dto.BatchID);
                        batch.QtyAvailable += dto.Qty;
                    }

                    var detail = new GoodsReceiptDetail
                    {
                        GoodsReceipt = receipt,
                        Batch = batch,
                        QtyIn = dto.Qty
                    };
                    context.GoodsReceiptDetails.Add(detail);
                }

                context.SaveChanges();
                transaction.Commit();
                XtraMessageBox.Show("Goods receipt saved successfully!");
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                XtraMessageBox.Show($"Error saving goods receipt: {ex.Message}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Do you want to cancel and reset the form?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                detailsList.Clear();
                txtReceiptCode.Text = GenerateReceiptCode();
                txtSupplier.Text = "";
                meNote.Text = "";
                RecalcSummary();
            }
        }

        private void frmNewGoodsReceipt_Load(object sender, EventArgs e)
        {

        }
    }
}