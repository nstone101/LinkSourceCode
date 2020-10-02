using Microsoft.AspNetCore.Mvc;
using src.Models;
using System.Diagnostics;

namespace src.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }


        #region Pages
        public IActionResult About()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult StoreLocator()
        {
            return View();
        }
        public IActionResult ComingSoon()
        {
            return View();
        }
        #endregion

        #region Home page

        public IActionResult IndexClassic()
        {
            return View();
        }
        public IActionResult IndexFashion()
        {
            return View();
        }
        public IActionResult IndexBoxed()
        {
            return View();
        }
        public IActionResult IndexSimple()
        {
            return View();
        }
        public IActionResult IndexAsymmetric()
        {
            return View();
        }
        public IActionResult IndexSidenav()
        {
            return View();
        }
        public IActionResult IndexLanding()
        {
            return View();
        }
        #endregion
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
