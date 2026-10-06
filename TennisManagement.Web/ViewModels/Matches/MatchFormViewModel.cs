using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using TennisManagement.Web.Application.Validations;
using TennisManagement.Web.Models.Matches.MatchEnumerations;

namespace TennisManagement.Web.ViewModels.Matches
{
    public class MatchFormViewModel
    {
        [Required(ErrorMessage = "First Player is required.")]
        [Range(1, 80)]
        [Display(Name = "First Player")]
        public int? FirstPlayerId { get; set; }

        [Required(ErrorMessage = "Second Player is required.")]
        [Display(Name = "Second Player")]
        public int? SecondPlayerId { get; set; }

        //When the user selects First Player from the dropdown menu, 
        //the player's name is removed automatically so that the Second Player
        //list does not already contain the name. The same applies
        //in the opposite direction (Second Player => First Player)
        public IEnumerable<SelectListItem> Players { get; set; } =
                    new List<SelectListItem>();


        [Required(ErrorMessage = "Date time is required.")]
        [ValidMatchDate]
        [Display(Name = "Date Time")]
        public DateTime? DateTime { get; set; }


        [Required(ErrorMessage = "Match status is required.")]
        [EnumDataType(typeof(MatchStatus),
            ErrorMessage = "Please select a valid option.")]
        [Display(Name = "Match Status")]
        public MatchStatus? MatchStatus { get; set; }


        [Required(ErrorMessage = "Court type is required.")]
        [EnumDataType(typeof(CourtType), 
            ErrorMessage = "Please select a valid option.")]
        [Display(Name = "Court Type")]
        public CourtType? CourtType { get; set; }

        [Required(ErrorMessage = "Court name is required.")]
        [Display(Name = "Court Name")]
        public string? CourtName { get; set; }


        [Required(ErrorMessage = "Venue is required.")]
        [Display(Name = "Venue")]
        public int? VenueId { get; set; }

        public IEnumerable<SelectListItem> Venues { get; set; } =
            new List<SelectListItem>();


        [Required(ErrorMessage = "Tournament is required.")]
        [Display(Name = "Tournament")]
        public int? TournamentId { get; set; }

        public IEnumerable<SelectListItem> Tournaments { get; set; } =
            new List<SelectListItem>();


        [Display(Name = "Score Result")]
        public string? ScoreResult { get; set; }


        //The user can select an option from the dropdown menu 
        //only if Match Status is Completed
        [Display(Name = "Winner")]
        public int? WinnerId { get; set; }

        public IEnumerable<SelectListItem> Winners { get; set; } =
            new List<SelectListItem>();
    }
}
