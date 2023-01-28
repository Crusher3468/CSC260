namespace Game_Library.Models
{
    public class Game
    {
        private static int nextID = 0;
        public int? Id { get; set; } = nextID++;

        public string Title { get; set; } = "[NO TITLE]";

		public int Year { get; set; }

        public string Platform { get; set; } = "Any";

        public string Genre { get; set; } = "None";

		public string Rating { get; set; } = "Not Rated";

        public string Image { get; set; }

        public string? LoanedTo { get; set; } = null;

        public string? LoanedDate { get; set; } = null;

        public Game()
        {

        }

        public Game(string title, int year, string platform, string genre, string rating, string image, string loanedTo, string loanedDate)
        {
            this.Title = title;
            this.Year = year;
            this.Platform = platform;
            this.Rating = rating;
            this.Genre = genre;
            this.Image = image;
            this.LoanedTo = loanedTo;
            this.LoanedDate = loanedDate;
        }
    }
}
