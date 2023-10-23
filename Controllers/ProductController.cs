using Microsoft.AspNetCore.Mvc;
using ScondDemoModels.Models;

namespace ScondDemoModels.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ProductList()
        {
            List<Product> products = new List<Product>()
            {
                new Product { Id = 1,Name="Mouse",Price=299},
                new Product { Id = 2, Name = "Pen", Price = 15},
                new Product { Id = 3,Name="Pensil",Price=10},
                new Product { Id = 4,Name="Pendrive",Price=399},
                new Product { Id = 5,Name="Notebook",Price=29},


            };
            ViewBag.List = products;
            return View();
        }
    }
}
