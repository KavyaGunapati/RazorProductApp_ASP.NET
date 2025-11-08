using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorProductApp.Data;
using RazorProductApp.Models;
using System.ComponentModel.DataAnnotations;

namespace RazorProductApp.Pages
{
    public class ProductModel : PageModel
    {
        private readonly AppDbContext _context;

        public ProductModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Product Product { get; set; }

        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Fill the form to add a product.";
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Products.Add(Product);
            _context.SaveChanges();

            Message = $"Product '{Product.Name}' with price ₹{Product.Price} saved successfully!";
            return Page();
        }
    }
}