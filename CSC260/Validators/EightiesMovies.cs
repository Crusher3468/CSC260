using Movie.Models;
using System.ComponentModel.DataAnnotations;

namespace CSC260.Validators
{
	public class EightiesMovies : ValidationAttribute
	{
		protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
		{
			var movie = (Movie)validationContext.ObjectInstance;

			if (movie.Year >= 1980 && movie.Year <= 1990)
			{
				return new ValidationResult("Movies cannot be bad");
			}
			return ValidationResult.Success;
		}
	}
}
