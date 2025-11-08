using System.ComponentModel.DataAnnotations;

namespace RazorProductApp.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Product name is required")]
        [StringLength(100, ErrorMessage = "Name length can't be more than 100")]
        public string Name { get; set; }

        [Range(1, 100000, ErrorMessage = "Price must be between ₹1 and ₹100000")]
        public decimal Price { get; set; }
    }
}