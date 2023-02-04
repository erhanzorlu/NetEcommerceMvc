using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetECommerce.BLL.AbstractService;
using NetECommerce.BLL.Service;
using NetECommerce.Entity.Entity;
using NetECommerce.MVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NetECommerce.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;

        public HomeController(IProductService productService,ICategoryService categoryService)
        {
            this.productService = productService;
            this.categoryService = categoryService;
        }

        public IActionResult Index()
        {
            TempData["deneme"] = "format uymuyor!";
            TempData["kategoriler"]=categoryService.GetAllCategorys();
      
            return View(productService.GetAllProducts().ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
