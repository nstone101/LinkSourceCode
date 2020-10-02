﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using src.Data;
using src.Models;

namespace src.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {        
          
            return View();
        }

        public IActionResult AddEdit( Guid id)
        {
            if (id == Guid.Empty)
            {
                Customer customer = new Customer();
              
                return View(customer);
            }
            else
            {
                return View(_context.Customer.Where(x => x.customerId.Equals(id)).FirstOrDefault());
            }

        }

        public IActionResult Detail(Guid customerId)
        {
            if (customerId == Guid.Empty)
            {
                return NotFound();
            }

            Customer customer = _context.Customer.Where(x => x.customerId.Equals(customerId)).FirstOrDefault();
          
            return View(customer);
        }
        
    }
}