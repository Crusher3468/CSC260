using Microsoft.AspNetCore.Mvc;
using Routing.Models;
using System.Diagnostics;

namespace Routing.Controllers
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

		public IActionResult Privacy()
		{
			return View();
		}

		public IActionResult CowMoo(int? id)
		{
			return Content("The cow Default Cow moos at you " + $"{id?.ToString()}" + " times.");
		}

		public IActionResult BetsyMoo(int? id, string name)
		{
			return Content("The cow " + name + " moos at you " + $"{id?.ToString()}" + " times.");
		}

		public IActionResult ChicFilA()
		{
			return Redirect("https://www.chick-fil-a.com/");
		}

		public IActionResult GalImage(int? id)
		{
			return Content("Showing images and information for all cows featured on the website\n" + $"{id?.ToString()}" + " cows per page");
		}

		public IActionResult GalPage1(int? id, int? pId)
		{
			return Content("Showing images and information for all cows featured on the website\n" + $"{id?.ToString()}" + " cows per page\n" +
				"Currently viewing page" + $"{pId?.ToString()}");
		}

		public IActionResult GalPage2(int? id, int? pId)
		{
			return Content("Showing images and information for all cows featured on the website\n" + $"{id?.ToString()}" + " cows per page\n" +
				"Currently viewing page " + $"{pId?.ToString()}");
		}


		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}