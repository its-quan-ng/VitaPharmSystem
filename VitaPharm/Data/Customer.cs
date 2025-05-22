using System.ComponentModel.DataAnnotations;

namespace VitaPharm.Data
{
    class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required]
        [MaxLength(200)]
        public string CustomerName { get; set; } = null!;

        [Required]
        [MaxLength(1)]
        public string Sex { get; set; } = null!;

        [MaxLength(20)]
        public string Contact { get; set; } = null!;

        [MaxLength(200)]
        public string CustomerAddress { get; set; } = null!;

        public virtual ICollection<Invoice> Invoice { get; } = new List<Invoice>();
    }
}
