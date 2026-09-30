using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using TennisManagement.Web.Application.Validations;
using TennisManagement.Web.Models.Matches.MatchEnumerations;

namespace TennisManagement.Web.ViewModels.Matches
{
    public class MatchFormViewModel
    {
        [Required(ErrorMessage = "Date time is required.")]
        [ValidMatchDate]
        [Display(Name = "Date Time")]
        public DateTime? DateTime { get; set; }

        [Required(ErrorMessage = "Court name is required.")]
        [RegularExpression(@"^[A-Z0-9][a-zA-Z0-9]*(?:[\s-][A-Z0-9][a-zA-Z0-9]*)*$",
         ErrorMessage = "Each word must start with a capital letter or a number" +
                        "separated by a single space or a hyphen.")]
        [Display(Name = "Court Name")]
        public string? CourtName { get; set; }

        [Required(ErrorMessage = "Court type is required.")]
        [EnumDataType(typeof(CourtType), 
            ErrorMessage = "Please select a valid option.")]
        [Display(Name = "Court Type")]
        public CourtType? CourtType { get; set; }

        [Required(ErrorMessage = "Match format is required.")]
        [EnumDataType(typeof(MatchFormat),
            ErrorMessage = "Please select a valid option.")]
        [Display(Name = "Match Format")]
        public MatchFormat? MatchFormat { get; set; }

        [Required(ErrorMessage = "Match kind is required.")]
        [EnumDataType(typeof(MatchKind),
            ErrorMessage = "Please select a valid option.")]
        [Display(Name = "Match Kind")]
        public MatchKind? MatchKind { get; set; }

        [Display(Name = "Score Result")]
        public string? ScoreResult { get; set; }

        [Display(Name = "Duration (Minutes)")]
        public int? DurationMinutes { get; set; }

        [Required(ErrorMessage = "Match status is required.")]
        [EnumDataType(typeof(MatchStatus),
            ErrorMessage = "Please select a valid option.")]
        [Display(Name = "Match Status")]
        public MatchStatus? MatchStatus { get; set; }

        [Required(ErrorMessage = "Venue Id is required.")]
        [Display(Name = "Venue")]
        public int? VenueId { get; set; }

        public IEnumerable<SelectListItem> Venues { get; set; } =
            new List<SelectListItem>();

        [Required(ErrorMessage = "Tournament Id is required.")]
        [Display(Name = "Tournament")]
        public int? TournamentId { get; set; }

        public IEnumerable<SelectListItem> Tournaments { get; set; } =
            new List<SelectListItem>();

        [Required(ErrorMessage = "First Player Id is required.")]
        [Display(Name = "First Player")]
        public int? FirstPlayerId { get; set; }

        [Required(ErrorMessage = "Second Player Id is required.")]
        [Display(Name = "Second Player")]
        public int? SecondPlayerId { get; set; }

        public IEnumerable<SelectListItem> Players { get; set; } =
            new List<SelectListItem>();

        [Display(Name = "Winner")]
        public int? WinnerId { get; set; }

        public IEnumerable<SelectListItem> Winners { get; set; } =
            new List<SelectListItem>();
    }
}
