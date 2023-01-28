using System.ComponentModel.DataAnnotations;

namespace CSC260.Models
{
	[EightiesMovies]
	public class Movie
	{
		private static int nextID = 0;
		public int? Id { get; set; } = nextID++;

		[Required(ErrorMessage = "Movie Title is Required, you dummy")]
		[MaxLength(40)]
		public string Title { get; set; } = "[NO TITLE]";

		[Required]
		[Range(1888, 2023)]
		public int? Year { get; set; } = 1888;

		[Required]
		[Range(1,5)]
		public float? Rating { get; set; } = 0f;

		public DateTime? ReleaseDate{ get; set; }

		public string Image { get; set; }

		public string Genre { get; set; }

		public Movie()
		{

		}

		public Movie(string title, int year, float rating)
		{
			this.Title = title;
			this.Year = year;
			this.Rating = rating;
		}

		public override string ToString()
		{
			return $"{Title} - {Year} - {Rating} stars";
		}
	}
}
