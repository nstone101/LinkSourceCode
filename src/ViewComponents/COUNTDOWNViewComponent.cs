using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.ViewComponents
{   
    public class COUNTDOWNViewComponent : ViewComponent
    {
       
        public COUNTDOWNViewComponent()
        {           
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {

            return View();
        }
    }
}
