using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorProductApp.Pages
{
    public class ProductModel : PageModel
    {
        // Bind form fields to these properties
        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public decimal Price { get; set; }

        public string Message { get; set; }

        // Called when page is loaded
        public void OnGet()
        {
            Message = "Fill the form to add a product.";
        }

        // Called when form is submitted
        public IActionResult OnPost()
        {
            // Simulate saving product
            Message = $"Product {Name} with price ₹{Price} saved successfully!";
            return Page(); // Reload the same page with message
        }
    }
}