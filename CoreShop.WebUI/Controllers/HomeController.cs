using CoreShop.BusinessLogic.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreShop.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IProductService _productService;

        public HomeController(IProductService productService)
        {
            _productService= productService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
