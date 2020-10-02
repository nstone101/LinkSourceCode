using Microsoft.AspNetCore.Mvc;
using src.Models;
using System.Diagnostics;

namespace src.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ImageLeft()
        {
            return View();
        }

        public IActionResult ImageGrid()
        {
            return View();
        }

        public IActionResult ImageSlider()
        {
            return View();
        }

        public IActionResult ImageStaked()
        {
            return View();
        }

      

    }
}
