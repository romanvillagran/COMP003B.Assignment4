using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment4.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }

        [Range(0.01, 1000)]
        public decimal Price { get; set; }

        [Required]
        public string ImageName { get; set; }

        [StringLength(500)]
        public string Description { get; set; }
    }
}
