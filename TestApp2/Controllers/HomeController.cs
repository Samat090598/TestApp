using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestApp2.Models;

namespace TestApp2.Controllers
{
    public class HomeController : Controller
    { 
        public IActionResult Index()
        {
            ViewData["Message"] = "Hello world!";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}