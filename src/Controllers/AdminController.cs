using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace src.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        #region Admin pages
        public IActionResult Chat()
        {
            return View();
        }
        public IActionResult Product()
        {
            return View();
        }
        public IActionResult ProductDetail()
        {
            return View();
        }
        public IActionResult Orders()
        {
            return View();
        }
        public IActionResult OrderDetail()
        {
            return View();
        }
        public IActionResult Customer()
        {
            return View();
        }
        public IActionResult ShoppingCart()
        {
            return View();
        }
        public IActionResult Checkout()
        {
            return View();
        }
        public IActionResult Sellers()
        {
            return View();
        }
        public IActionResult PageProfile()
        {
            return View();
        }
        public IActionResult PageProfile2()
        {
            return View();
        }
        public IActionResult PageInvoice()
        {
            return View();
        }
        public IActionResult PageFaq()
        {
            return View();
        }
        public IActionResult PagePricing()
        {
            return View();
        }
        public IActionResult PageMaintenance()
        {
            return View();
        }
        public IActionResult PageLogin()
        {
            return View();
        }
        public IActionResult PageRegister()
        {
            return View();
        }
        public IActionResult PageTimeline()
        {
            return View();
        }
       
        #endregion

        #region BaseUI

        public IActionResult Accordions()
        {
            return View();
        }
        public IActionResult alerts()
        {
            return View();
        }
        public IActionResult avatars()
        {
            return View();
        }
        public IActionResult badges()
        {
            return View();
        }
        public IActionResult breadcrumb()
        {
            return View();
        }
        public IActionResult buttons()
        {
            return View();
        }
        public IActionResult cards()
        {
            return View();
        }
        public IActionResult carousel()
        {
            return View();
        }
        public IActionResult dropdowns()
        {
            return View();
        }
        public IActionResult embedvideo()
        {
            return View();
        }
        public IActionResult grid()
        {
            return View();
        }
        public IActionResult group()
        {
            return View();
        }
        public IActionResult mediaobject ()
        {
            return View();
        }
        public IActionResult modals()
        {
            return View();
        }
        public IActionResult notifications()
        {
            return View();
        }
        public IActionResult pagination()
        {
            return View();
        }
        public IActionResult popovers()
        {
            return View();
        }
        public IActionResult progress()
        {
            return View();
        }
        public IActionResult ribbons()
        {
            return View();
        }
        public IActionResult spinners()
        {
            return View();
        }
        public IActionResult tabs()
        {
            return View();
        }
        public IActionResult tooltips()
        {
            return View();
        }
        public IActionResult typography()
        {
            return View();
        }
        public IActionResult dragula()
        {
            return View();
        }
        public IActionResult rangeslider()
        {
            return View();
        }
        public IActionResult ratings()
        {
            return View();
        }
        public IActionResult scrollbar()
        {
            return View();
        }
        public IActionResult scrollspy()
        {
            return View();
        }
        public IActionResult widgets()
        {
            return View();
        }
        #endregion

        #region ICON
        public IActionResult dripicons()
        {
            return View();
        }
        public IActionResult iconsmdi()
        {
            return View();
        }
        public IActionResult unicons()
        {
            return View();
        }

        #endregion

        #region FORM
        public IActionResult elements()
        {
            return View();
        }
        public IActionResult advanced()
        {
            return View();
        }
        public IActionResult validation()
        {
            return View();
        }
        public IActionResult wizard()
        {
            return View();
        }
        public IActionResult fileuploads()
        {
            return View();
        }
        public IActionResult editors()
        {
            return View();
        }

        #endregion

        #region Table
        public IActionResult basic()
        {
            return View();
        }
        public IActionResult datatable()
        {
            return View();
        }

        #endregion
        #region MAP
        public IActionResult google()
        {
            return View();
        }
        public IActionResult vector()
        {
            return View();
        }

        #endregion

    }
}