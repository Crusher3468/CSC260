using CSC260.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CSC260.Controllers
{
    public class HomeController : Controller
    {
        private static int intCount;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult RouteTest(int? id)
        {
            return Content($"id = {id?.ToString() ?? "Null"}");
        }

        public IActionResult Index(int? id, string s)
        {
            return Content($"id {id?.ToString() ?? "NULL"}");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Future()
        {
            return View();
        }

		public IActionResult Counter()
		{
            ViewBag.Count = intCount++;
			return View();
		}

        public IActionResult Input()
        {
            return View();
        }

        public IActionResult Output()
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