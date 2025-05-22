using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VitaPharm.Data
{
    class GoodsReceiptDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GoodsReceiptDetailID { get; set; }
        public int QtyIn { get; set; }

        public virtual Batch Batch { get; set; } = null!;
        public virtual GoodsReceipt GoodsReceipt { get; set; } = null!;
    }
}
