using TennisManagement.Web.Models.Matches.MatchEnumerations;

namespace TennisManagement.Web.ViewModels.Matches
{
    public class MatchInfoViewModel
    {
        public int Id { get; set; }

        public DateTime DateTime { get; set; }

        public string CourtName { get; set; } = string.Empty;

        public CourtType CourtType { get; set; }

        public MatchFormat MatchFormat { get; set; }

        public MatchKind MatchKind { get; set; }

        public string? ScoreResult { get; set; }

        public int? DurationMinutes { get; set; }

        public MatchStatus MatchStatus { get; set; }

        // Flattened Venue Information
        public int VenueId { get; set; }

        public string VenueName { get; set; } = string.Empty;

        // Flattened Tournament Information
        public int TournamentId { get; set; }

        public string TournamentName { get; set; } = string.Empty;

        // Flattened Player Information
        public int FirstPlayerId { get; set; }

        public string FirstPlayerFullName { get; set; } = string.Empty;

        public int SecondPlayerId { get; set; }

        public string SecondPlayerFullName { get; set; } = string.Empty;

        public int? WinnerId { get; set; }

        public string? WinnerFullName { get; set; }

        // Computed helper property for UI display
        public bool IsCompleted => this.MatchStatus == MatchStatus.Completed;
    }
}
