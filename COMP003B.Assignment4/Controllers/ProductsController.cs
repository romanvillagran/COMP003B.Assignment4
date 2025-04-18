﻿using COMP003B.Assignment4.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment4.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("products")]

    public class ProductsController : Controller
    {

        private static List<Product> _products = new List<Product> {
        new Product { Id=1, Name="plastic bottle", Price=14.99m, ImageName="bottle1.jpg", Description="Standard water bottle" },
        new Product { Id=2, Name="metal bottle", Price=19.99m, ImageName="bottle2.jpg", Description="metal water bottle" },
        new Product { Id=3, Name="glass bottle", Price=29.99m, ImageName="bottle3.jpg", Description="glass water bottle" }
    };

        public IActionResult Index()
        {
            return View(_products);
        }

    }
}
