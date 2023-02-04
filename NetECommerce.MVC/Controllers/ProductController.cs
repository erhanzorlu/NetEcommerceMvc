using Microsoft.AspNetCore.Mvc;
using NetECommerce.BLL.AbstractService;
using System.Linq;

namespace NetECommerce.MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            return View(_productService.GetAllProducts().ToList());
        }
    }
}
