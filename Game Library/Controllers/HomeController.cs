using Game_Library.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Game_Library.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private static List<Game> GameList = new List<Game>
        {
            new Game("Horizon Zero Dawn", 2017, "Playstation", "Open World Action-Adventure", "T", "HorizonZeroDawn.jpg", null, null),
            new Game("Horizon Forbidden West", 2022, "Playstation", "Open World Action-Adventure", "T", "HorizonForbiddenWest.jpg", "Brandon", "10/11/2022"),
            new Game("Titanfall 2", 2016, "Xbox", "First-Person Shooter", "M", "Titanfall_2.jpg", null, null),
            new Game("Biomutant", 2021, "Playstation", "Action Role-Playing", "T", "Biomutant.jpg", "Porter", "1/5/2023"),
            new Game("Ark", 2015, "Xbox", "Action-Adventure Survival", "T", "Ark.jpg", null, null),
        };

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

		public IActionResult Collection()
		{
			return View(GameList);
		}

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(Game g)
		{
			if (g != null)
			{
				GameList.Add(g);
				TempData["success"] = "Game Created";
				return RedirectToAction("Collection", "Home");
			}
			return View();
		}

        public IActionResult Loan()
        {
            return View();
        }

        [HttpPost]
		public IActionResult Loan(string title, string loanedTo, string loanedDate)
		{
            foreach (Game g in GameList) { 
                if (g.Title == title) 
                {
                    g.LoanedTo = loanedTo;
                    g.LoanedDate = loanedDate;
                }
            }
            return View();
		}

		public IActionResult Return()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Return(string title)
		{
			foreach (Game g in GameList)
			{
				if (g.Title == title)
				{
					g.LoanedTo = null;
					g.LoanedDate = null;
				}
			}
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}