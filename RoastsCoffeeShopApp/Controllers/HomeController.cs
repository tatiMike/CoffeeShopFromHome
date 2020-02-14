using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using RoastsCoffeeShopApp.Models;
using Microsoft.AspNetCore.Authorization;

namespace RoastsCoffeeShopApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            if (ModelState.IsValid)
            {
                ShopDBContext db = new ShopDBContext();
                var itemList = new List<ItemsCoffee>();
                AspNetUsers confirmedUsers = new AspNetUsers();
                if (confirmedUsers == null)
                {
                    return HttpNotFound();
                }
                db.SaveChanges();
                return View(db);
            }
            return View("Login");
        }

        private IActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }

        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
