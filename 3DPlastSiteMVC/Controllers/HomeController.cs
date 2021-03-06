using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _PlastSiteMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace _PlastSiteMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly PlastContext _dbContext;
        public HomeController(PlastContext context)
        {
            _dbContext = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Content()
        {
            return View();
        }
        public IActionResult ContentPageOne()
        {
            return View();
        }
        public IActionResult ContentPageTwo()
        {
            return View();
        }
        public IActionResult LogIn(int id)
        {
            ViewBag.UserId = id;
            return View();
        }
        [HttpPost]
        public IActionResult LogIn(User user)
        {
            var userDb = _dbContext.Users.FirstOrDefault(us => us.UserLogin == user.UserLogin);
            if (userDb != null)
            {
                return View("Content");
            }
            return View("Error");
        }
        public IActionResult SignUp(int id)
        {
            ViewBag.UserId = id;
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(User user)
        {
            if (user != null)
            {
                _dbContext.Add(user);
                _dbContext.SaveChanges();
            }
            else
            {
                return View("Error");
            }
            return Redirect("~/Home/Index");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
