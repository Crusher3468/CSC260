using Mad_Lib.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Mad_Lib.Controllers
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

		public IActionResult MadLib(string person, string adj1, string place, string food1, string food2, string food3, string adj2, string celeb, string song, string verb)
		{
			ViewBag.person = person;
			ViewBag.adj1 = adj1;
			ViewBag.place = place;
			ViewBag.food1 = food1;
			ViewBag.food2 = food2;
			ViewBag.food3 = food3;
			ViewBag.adj2 = adj2;
			ViewBag.celeb = celeb;
			ViewBag.song = song;
			ViewBag.verb = verb;

			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}