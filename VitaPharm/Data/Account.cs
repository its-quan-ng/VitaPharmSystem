using System.ComponentModel.DataAnnotations;

namespace VitaPharm.Data
{
    class Account
    {
        [Key]
        public int AccountID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; } = null!;

        [Required]
        [MaxLength(256)]
        public string UserPassword { get; set; } = null!;

        [Required]
        [MaxLength(5)]
        public string UserRole { get; set; } = null!;

        [Required]
        [MaxLength(10)]
        public string IsActive { get; set; } = null!;

        public virtual Employee Employee { get; set; } = null!;
    }
}
