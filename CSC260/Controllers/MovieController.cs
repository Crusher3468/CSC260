using CSC260.Data;
using CSC260.Models;
using Microsoft.AspNetCore.Mvc;

namespace CSC260.Controllers
{
	public class MovieController : Controller
	{
		private static List<Movie> MovieList = new List<Movie>
		{
			new Movie("Lion King", 1994, 4f),
			new Movie("Trip to the Moon", 1902, 5f),
			new Movie("Megamind", 2010, 5f)
		};

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Movie m)
        {
			if (m.Title == "The Room")
			{
				ModelState.AddModelError("CustomError", "That movie sucks");
			}
			if (m != null)
			{
				MovieList.Add(m);
				TempData["success"] = "Movie Created";
				return RedirectToAction("MultMovies", "Movie");
			}
			return View();
        }

		public IActionResult Edit()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Edit(int? id)
		{
			//if (id == null) return NotFound();

			//Movie foundMovie = MovieList.Where(m => m.Id == id).FirstOrDefault();

			//if (foundMovie == null) return NotFound();

			return View(foundMovie);
		}

		[HttpPost]
		public IActionResult Edit(Movie m)
		{
			int i;
			dal.addMovie;
			TempData["Success"] = "Movie " + m.Title + "updated";
			return RedirectToAction("MultMovies", "Movie");
		}

		[HttpPost]
		public IActionResult Delete(int? id)
		{
			int i;
			i = MovieList.FindIndex(x => x.Id == id);
			if (i == -1) return NotFound();
			TempData["Success"] = "Movie " + MovieList[i].Title + "Deleted";
			MovieList.RemoveAt(i);
			return RedirectToAction("MultMovies", "Movie");
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult MultMovies()
		{
			return View(dal.GetMovies);
		}

		public IActionResult DisplayMovies()
		{
			Movie m = new Movie("Tron", 1982, 5);
			return View(m);
		}
	}
}
