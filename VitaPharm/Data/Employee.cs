using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VitaPharm.Data
{
    class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeID { get; set; }

        [Required]
        [MaxLength(200)]
        public string EmployeeName { get; set; } = null!;

        [Required]
        [MaxLength(1)]
        public string Sex { get; set; } = null!;

        [MaxLength(20)]
        public string Contact { get; set; } = null!;

        [Column(TypeName = "date")]
        public DateTime Birthday { get; set; }

        [MaxLength(200)]
        public string EmployeeAddress { get; set; } = null!;

        public virtual ICollection<Account> Account { get; } = new List<Account>();
        public virtual ICollection<Invoice> Invoice { get; } = new List<Invoice>();
        public virtual ICollection<GoodsReceipt> GoodsReceipt { get; } = new List<GoodsReceipt>();
    }
}
