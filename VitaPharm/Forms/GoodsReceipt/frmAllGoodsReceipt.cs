using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using VitaPharm.Data;

namespace VitaPharm.Forms
{
    public partial class frmAllGoodsReceipt : DevExpress.XtraEditors.XtraForm
    {
        private PharmacyDbContext context = new PharmacyDbContext();

        public frmAllGoodsReceipt()
        {
            InitializeComponent();
        }

        private void frmAllGoodsReceipt_Load(object sender, EventArgs e)
        {
            var receipts = context.GoodsReceipts
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

        private void btnNewGoodsReceipt_Click(object sender, EventArgs e)
        {

        }

        private void btnDeactive_Click(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}