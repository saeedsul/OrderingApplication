﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrderingApplication.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderingApplication.Controllers
{
    public class OrderController : Controller
    {
        // GET: /<controller>/
        public IActionResult NewOrder()
        {
            return View();
        }
    }
}
