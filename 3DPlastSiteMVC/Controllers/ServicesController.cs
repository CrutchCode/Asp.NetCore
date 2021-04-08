using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PlastSiteMVC.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult GallaryPhotosOfProducts()
        {
            return View();
        }
        public IActionResult PhotoPrinter()
        {
            return View();
        }
        public IActionResult CustomModelDevelopment()
        {
            return View();
        }
        public IActionResult CustomPrinting()
        {
            return View();
        }
    }
}