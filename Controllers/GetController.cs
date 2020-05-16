﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SSuwalaBonjourLeMonde.Controllers
{
    public class GetController : Controller
    {
        public IActionResult Index(String name = "Sebastian")
        {
            ViewData["name"] = name;
            return View();
        }
    }
}