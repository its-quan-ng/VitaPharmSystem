using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VitaPharm.Data
{
    class Invoice
    {
        [Key]
        public int InvoiceID { get; set; }

        [Required]
        [MaxLength(15)]
        public string InvoiceCode { get; set; } = null!;

        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }

        [MaxLength(200)]
        public string Note { get; set; } = null!;

        public float TaxRate { get; set; }

        public virtual Employee Employee { get; set; } = null!;
        public virtual Customer Customer { get; set; } = null!;
        public virtual ICollection<InvoiceDetail> InvoiceDetail { get; } = new List<InvoiceDetail>();
    }
}
