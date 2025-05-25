using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VitaPharm.Data
{
    class InvoiceDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InvoiceDetailID { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }

        [Column(TypeName = "money")]

        [NotMapped]
        public decimal Amount => Quantity * UnitPrice;
        [NotMapped] public int OnHand { get; set; }   // tồn kho (hiển thị)
        public virtual Invoice Invoice { get; set; } = null!;
        public int BatchID { get; set; }
        public virtual Batch Batch { get; set; } = null!;
    }
}
