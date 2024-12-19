using Microsoft.AspNetCore.Mvc;
using FirstASP.Models;
using System.Collections.Generic;

namespace FirstASP.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Кулька ялинкова", Price = 29.90m },
                new Product { Id = 2, Name = "Серпантин", Price = 45.00m },
                new Product { Id = 3, Name = "Вогні бенгальські", Price = 84.40m },
                new Product { Id = 4, Name = "Гірлянда 3м", Price = 129.90m },
                new Product { Id = 5, Name = "Ялинка штучна 1.5м", Price = 1229.90m }
            };

            return View(products); 
        }
    }
}
