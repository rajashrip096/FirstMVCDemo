using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstMVCDemo.Models;

namespace FirstMVCDemo.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            List<Product> products = new List<Product>()
            {
                new Product{Id=1,Name="Dell Laptop",Price=34000},
                new Product{Id=2,Name="Hp Laptop",Price=40000},
                new Product{Id=3,Name="Lenovo Laptop",Price=37000},
                new Product{Id=4,Name="Dell Mouse",Price=340},
                new Product{Id=5,Name="Dell Keyboard",Price=2000},
                new Product{Id=6,Name="RAM",Price=300},
                new Product{Id=7,Name="Hp Mouse",Price=600},
            };
            ViewData["productList"] = products;
            ViewBag.Products = products;
            return View();
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            return View();
        }
    }
}
