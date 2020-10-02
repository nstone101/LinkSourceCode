using Microsoft.AspNetCore.Mvc;
using src.Models;
using System.Diagnostics;

namespace src.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Collapse()
        {
            return View();
        }

        public IActionResult Masonry()
        {
            return View();
        }

        public IActionResult Simple()
        {
            return View();
        }

        public IActionResult Topbar()
        {
            return View();
        }

        public IActionResult Locator()
        {
            return View();
        }

        #region Support

        public IActionResult ShoppingCart()
        {
            return View();
        }
        public IActionResult Checkout()
        {
            return View();
        }
        public IActionResult OrderCompleted()
        {
            return View();
        }
        public IActionResult ShippingAndReturns()
        {
            return View();
        }
        
        #endregion

    }
}
