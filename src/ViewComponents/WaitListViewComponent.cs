﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.ViewComponents
{   
    public class WaitListViewComponent : ViewComponent
    {
       
        public WaitListViewComponent()
        {           
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {

            return View();
        }
    }
}
