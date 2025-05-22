using System.ComponentModel.DataAnnotations;

namespace VitaPharm.Data
{
    class Categories
    {
        [Key]
        public int CategoryID { get; set; }

        [Required]
        [MaxLength(50)]
        public string CategoryName { get; set; } = null!;

        public virtual ICollection<Commodity> Commodity { get; } = new List<Commodity>();
    }
}
