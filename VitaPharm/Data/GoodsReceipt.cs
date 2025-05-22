using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VitaPharm.Data
{
    class GoodsReceipt
    {
        [Key]
        public int ReceiptID { get; set; }

        [Required]
        [MaxLength(6)]
        public string ReceiptCode { get; set; } = null!;

        [Column(TypeName = "date")]
        public DateTime ReceiptDate { get; set; }

        [Required]
        [MaxLength(200)]
        public string SupplierName { get; set; } = null!;

        [MaxLength(200)]
        public string Note { get; set; } = null!;

        [Required]
        [MaxLength(10)]
        public string ReceiptStatus { get; set; } = null!;

        public virtual Employee Employee { get; set; } = null!;
        public virtual ICollection<GoodsReceiptDetail> GoodsReceiptDetail { get; } = new List<GoodsReceiptDetail>();
    }
}
