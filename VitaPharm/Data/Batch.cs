using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VitaPharm.Data
{
    class Batch
    {
        [Key]
        public int BatchID { get; set; }

        [Required]
        [MaxLength(30)]
        public string BatchCode { get; set; } = null!;

        [Column(TypeName = "date")]
        public DateTime MfgDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime ExpDate { get; set; }

        public int QtyAvailable { get; set; }

        [Column(TypeName = "money")]
        public decimal PurchasePrice { get; set; }

        [Required]
        [MaxLength(10)]
        public string BatchStatus { get; set; } = null!;

        public virtual Commodity Commodity { get; set; } = null!;
        public virtual ICollection<GoodsReceiptDetail> GoodsReceiptDetail { get; } = new List<GoodsReceiptDetail>();
    }
}
