using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using VitaPharm.Data;

namespace VitaPharm.Forms.Receipt
{
    public partial class frmAllGoodsReceipt : XtraForm
    {
        private PharmacyDbContext context = new PharmacyDbContext();
        private string currentUser;

        public frmAllGoodsReceipt(string username)
        {
            InitializeComponent();
            currentUser = username;
            LoadReceipts();
        }

        private void frmAllGoodsReceipt_Load(object sender, EventArgs e)
        {
            LoadReceipts();

            if (!string.IsNullOrEmpty(CurrentUser.Role) && 
                CurrentUser.Role.Trim().Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                btnDeactive.Enabled = false;
            }
            else
            {
                btnDeactive.Enabled = true;
            }
        }

        private void btnNewGoodsReceipt_Click(object sender, EventArgs e)
        {
            var frm = new frmNewGoodsReceipt(currentUser);
            frm.ShowDialog();
            LoadReceipts();
        }

        private void btnDeactive_Click(object sender, EventArgs e)
        {
            int rowHandle = gridView.FocusedRowHandle;
            if (rowHandle < 0)
            {
                XtraMessageBox.Show("Please select a receipt to deactivate.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var receiptID = gridView.GetRowCellValue(rowHandle, "ReceiptID");
            if (receiptID == null)
            {
                XtraMessageBox.Show("Invalid selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (XtraMessageBox.Show("Are you sure you want to deactivate this receipt?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var receipt = context.GoodsReceipts.FirstOrDefault(r => r.ReceiptID == (int)receiptID);
                if (receipt != null)
                {
                    receipt.ReceiptStatus = "Canceled";
                    context.SaveChanges();
                    LoadReceipts();
                    XtraMessageBox.Show("Receipt deactivated.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            frmAllGoodsReceipt_Load(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Do you want to exit this screen?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void LoadReceipts()
        {
            IQueryable<GoodsReceipt> query = context.GoodsReceipts;

            if (CurrentUser.Role.Trim().Equals("user", StringComparison.OrdinalIgnoreCase))
            {
                query = query.Where(r => r.Employee.EmployeeID == CurrentUser.EmployeeID);
            }
            
            var receipts = query
                .Select(r => new
                {
                    r.ReceiptID,
                    r.ReceiptCode,
                    r.ReceiptDate,
                    r.SupplierName,
                    r.Note,
                    r.ReceiptStatus
                })
                .ToList();
            gridControl.DataSource = receipts;
        }
    }
}