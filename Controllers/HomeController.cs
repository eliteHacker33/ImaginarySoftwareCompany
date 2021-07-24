using ImaginarySoftwareCompany.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ImaginarySoftwareCompany.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("SoftwareSearch");
        }
    }
}
