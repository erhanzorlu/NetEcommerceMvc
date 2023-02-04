using Microsoft.AspNetCore.Mvc;
using NetECommerce.BLL.AbstractService;
using System.Linq;

namespace NetECommerce.MVC.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]

    public class HomeController : Controller
    {
        decimal fiyat = 0;
        private  IProductService _productService;
        public HomeController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
           
            foreach (var item in _productService.GetAllProducts().ToList())
            {
                fiyat += item.UnitPrice;
            }

            ViewBag.toplamUrun = _productService.GetAllProducts().Count();
            ViewBag.toplamFiyat = fiyat;
            return View();
        }
    }
}
