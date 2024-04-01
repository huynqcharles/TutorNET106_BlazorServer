using System.ComponentModel.DataAnnotations;

namespace Shared
{
    public class Product
    {
        public int ID { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Name toi thieu phai 3 ky tu")]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public decimal Price { get; set; }

        [Required]
        public string ImagePath { get; set; }
    }
}
