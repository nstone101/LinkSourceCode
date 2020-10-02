using Microsoft.AspNetCore.Mvc;
using src.Models;
using System.Diagnostics;

namespace src.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult AccountOrder()
        {
            return View();
        }
        public IActionResult AccountOrders()
        {
            return View();
        }

        public IActionResult PersonalInfo()
        {
            return View();
        }

        public IActionResult WishList()
        {
            return View();
        }

        public IActionResult Auth()
        {
            return View();
        }

       
    }
}
