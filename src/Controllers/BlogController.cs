using Microsoft.AspNetCore.Mvc;
using src.Models;
using System.Diagnostics;

namespace src.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BlogPost()
        {
            return View();
        }
    }
}
