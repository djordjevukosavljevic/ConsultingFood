using System.Diagnostics;
using ConsultingFood.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConsultingFood.Controllers
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
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Reviews()
        {
            return View();
        }

        public IActionResult Meat()
        {
            return View();
        }

        public IActionResult Fruit()
        {
            return View();
        }

        public IActionResult Milk()
        {
            return View();
        }


        public IActionResult Gallery()
        {
            return View();
        }

        public IActionResult Appointments()
        {
            return View();
        }
    }
}
