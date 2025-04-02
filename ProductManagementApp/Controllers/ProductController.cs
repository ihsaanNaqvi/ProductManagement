using Microsoft.AspNetCore.Mvc;
using ProductManagementApp.Models;
using System.Collections.Generic;

namespace ProductManagementApp.Controllers
{
    public class ProductController : Controller
    {
        // Simulated product list for demonstration purposes
        private static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 999.99M },
            new Product { Id = 2, Name = "Smartphone", Price = 699.99M }
        };

        // Action to display the list of products
        public IActionResult Index()
        {
            return View(products);
        }

        // Action to display the details of a single product
        public IActionResult Details(int id)
        {
            var product = products.Find(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
    }
}
