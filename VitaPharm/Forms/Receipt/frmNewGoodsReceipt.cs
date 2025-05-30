using System.ComponentModel;
using DevExpress.XtraEditors;
using VitaPharm.Data;
using Microsoft.EntityFrameworkCore; 

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
            
            gridControl.DataSource = detailsList;
            InitializeForm();
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

        private void RepoSpinQty_EditValueChanged(object sender, EventArgs e)
        {
            var spinEdit = sender as SpinEdit;
            if (spinEdit == null) return;

            var dto = gridView.GetFocusedRow() as BatchDto;
            if (dto == null) return;

            dto.Qty = (int)spinEdit.Value;
            gridView.RefreshRow(gridView.FocusedRowHandle);
            RecalcSummary();
        }

        private void InitializeForm()
        {
            dateReceiptDate.DateTime = DateTime.Now;
            txtReceiptCode.Text = GenerateReceiptCode();
            txtReceiptCode.Properties.ReadOnly = true;

            var account = context.Accounts
                .Include(a => a.Employee)
                .FirstOrDefault(a => a.Username == currentUser);

            if (account != null && account.Employee != null)
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
            repoBtnDelete.ButtonClick += RepoBtnDelete_ButtonClick;
            repoSpinQty.EditValueChanged += RepoSpinQty_EditValueChanged;
            using var dlg = new frmNewBatch();
            if (dlg.ShowDialog() == DialogResult.OK && dlg.ResultBatch != null)
            {
                BatchDto existingBatch = null;
                if (dlg.ResultBatch.BatchID == 0)
                {
                    existingBatch = detailsList.FirstOrDefault(b =>
                        b.BatchID == 0 &&
                        b.CommodityID == dlg.ResultBatch.CommodityID &&
                        b.MfgDate == dlg.ResultBatch.MfgDate &&
                        b.ExpDate == dlg.ResultBatch.ExpDate &&
                        b.PurchasePrice == dlg.ResultBatch.PurchasePrice
                    );
                }
                else
                {
                    existingBatch = detailsList.FirstOrDefault(b => b.BatchID == dlg.ResultBatch.BatchID);
                }

                if (existingBatch != null)
                {
                    existingBatch.Qty += dlg.ResultBatch.Qty;
                }
                else
                {
                    detailsList.Add(dlg.ResultBatch);
                }
                RecalcSummary();
            }
        }

        private void ResetForm()
        {
            txtReceiptCode.Text = GenerateReceiptCode();
            txtSupplier.Text = "";
            meNote.Text = "";
            dateReceiptDate.DateTime = DateTime.Now;
            detailsList.Clear();
            RecalcSummary();
        }

        private void RecalcSummary()
        {
            decimal total = detailsList.Sum(d => d.Qty * d.PurchasePrice);
            lblTotal.Text = total.ToString("N2");
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
                frmNewGoodsReceipt_Load(sender, e);
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
                frmNewGoodsReceipt_Load(sender, e);
            }
        }

        private void frmNewGoodsReceipt_Load(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}