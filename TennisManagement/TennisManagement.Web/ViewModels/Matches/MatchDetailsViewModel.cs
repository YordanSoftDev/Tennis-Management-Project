using TennisManagement.Web.Models.Matches.MatchEnumerations;

namespace TennisManagement.Web.ViewModels.Matches
{
    public class MatchDetailsViewModel
    {
        public int Id { get; set; }

        public DateTime DateTime { get; set; }

        public string CourtName { get; set; } = string.Empty;

        public string CourtType { get; set; } = string.Empty;

        public string MatchFormat { get; set; } = string.Empty;

        public string MatchKind { get; set; } = string.Empty;

        public string? ScoreResult { get; set; } = string.Empty;

        public int? DurationMinutes { get; set; }

        public string MatchStatus { get; set; } = string.Empty;

        public string VenueId { get; set; } = string.Empty;

        public string TournamentId { get; set; } = string.Empty;

        public string FirstPlayerId { get; set; } = string.Empty;

        public string SecondPlayerId { get; set; } = string.Empty;

        public string? WinnerId { get; set; } = string.Empty;
    }
}
