using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.ViewComponents
{   
    public class REVIEWSViewComponent : ViewComponent
    {
       
        public REVIEWSViewComponent()
        {           
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {

            return View();
        }
    }
}
