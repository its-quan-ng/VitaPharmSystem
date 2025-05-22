using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VitaPharm.Data
{
    class InvoiceDetail
    {
        [Key]
        public int InvoiceDetailID { get; set; }
        public int Quantity { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        [Required]
        [MaxLength(10)]
        public string InvoiceStatus { get; set; } = null!;

        public virtual Invoice Invoice { get; set; } = null!;
        public virtual Commodity Commodity { get; set; } = null!;
    }
}
