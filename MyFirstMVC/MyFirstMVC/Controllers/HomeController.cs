using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstMVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string firstName, string lastName)
        {
            return RedirectToAction("Results", new { firstName, lastName });
        }

        public IActionResult Results(string begining, string end)
        {
            Search result = new Search(beginning, end);
            return View(result);
        }
    }

}