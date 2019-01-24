using Microsoft.AspNetCore.Mvc;
using MyFirstMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public IActionResult Index(int startYear, int endYear)
        {
            return RedirectToAction("Results", new { startYear, endYear });
        }

        [HttpGet]
        public IActionResult Results(int startYear, int endYear)
        {
            return View(TimePerson.GetPersons(startYear, endYear));
        }
    }

}