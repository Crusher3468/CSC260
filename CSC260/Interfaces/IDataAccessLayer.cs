using CSC260.Data;
using CSC260.Models;
using System.Collections.Generic;


namespace CSC260.Interfaces
{
    public class IDataAccessLayer
    {
		//private static List<Movie> MovieList = new List<Movie>
		//{
		//	new Movie("Lion King", 1994, 4f),
		//	new Movie("Trip to the Moon", 1902, 5f),
		//	new Movie("Megamind", 2010, 5f)
		//};

		IDataAccessLayer dal = new MovieListDal();

		IEnumerable<Movie> GetMovies()
        {
			return MovieList;
		}

        void AddMovie(Movie movie)
		{
			MovieList.Add(movie);	
		}

		void RemoveMovie(int? id)
		{
			throw new NotImplementedException();
		}

		void EditMovie(Movie m)
		{
			if (id == null) return NotFound();

			Movie foundMovie = MovieList.Where(m => m.Id == id).FirstOrDefault();

			if (foundMovie == null) return NotFound();

			return View(foundMovie);
		}

		Movie GetMovie(int? id)
		{
			throw new NotImplementedException();
		}
	}
}
