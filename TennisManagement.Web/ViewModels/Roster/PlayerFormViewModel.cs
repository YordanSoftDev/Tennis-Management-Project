using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using TennisManagement.Web.Models.Country;

namespace TennisManagement.Web.ViewModels.Roster
{
    public class PlayerFormViewModel
    {
        [Required(ErrorMessage = "Please enter a First Name.")]
        [StringLength(20, MinimumLength = 2)]
        [RegularExpression(@"^[A-Z][a-z]+$",
         ErrorMessage = "First name must start with an uppercase letter " +
                        "followed by one or more lowercase letters.")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a Last Name.")]
        [StringLength(20, MinimumLength = 2)]
        [RegularExpression(@"^[A-Z][a-z]+$",
         ErrorMessage = "Last name must start with an uppercase letter " +
                        "followed by one or more lowercase letters.")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Age is required.")]
        [Range(13, 45, ErrorMessage = "Age must be " +
            "between 13 and 45.")]
        public int? Age { get; set; }

        [Required(ErrorMessage = "Weight is required.")]
        [RegularExpression(@"^\d{2,3} lbs/\(\d{2,3}kg\)$",
            ErrorMessage = "Weight value must be in the format " +
            "170 lbs/(77kg)")]
        public string? Weight { get; set; }

        [Required(ErrorMessage = "Height is required.")]
        [RegularExpression(@"^\d{1}'\d{1}""/\(\d{3}cm\)$",
            ErrorMessage = "Height value must be in the format " +
            "6'3/(191cm)")]
        public string? Height { get; set; }

        [Required(ErrorMessage = "Please select a country.")]
        public int CountryId { get; set; }

        [Required(ErrorMessage = "Birthplace is required.")]
        [StringLength(100, ErrorMessage = "Birthplace's max length is 100 symbols.")]
        public string? Birthplace { get; set; }

        public IEnumerable<SelectListItem> Countries { get; set; } = Enumerable.Empty<SelectListItem>();
    }
}
