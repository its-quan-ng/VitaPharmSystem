using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VitaPharm.Data
{
    class Commodity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CommodityID { get; set; }

        [Required]
        [MaxLength(200)]
        public string CommodityName { get; set; } = null!;

        [Required]
        [MaxLength(30)]
        public string BaseUnit { get; set; } = null!;

        [Column(TypeName = "money")]
        public decimal SellingPrice { get; set; }

        [Required]
        [MaxLength(10)]
        public string IsTerminated { get; set; } = null!;

        public virtual Categories Categories { get; set; } = null!;
        public virtual ICollection<Batch> Batch { get; } = new List<Batch>();
        public virtual ICollection<InvoiceDetail> InvoiceDetail { get; } = new List<InvoiceDetail>();
    }
}
