using System.ComponentModel.DataAnnotations;

namespace VitaPharm.Data
{
    class GoodsReceiptDetail
    {
        [Key]
        public int GoodsReceiptDetailID { get; set; }
        public int QtyIn { get; set; }

        public virtual Batch Batch { get; set; } = null!;
        public virtual GoodsReceipt GoodsReceipt { get; set; } = null!;
    }
}
