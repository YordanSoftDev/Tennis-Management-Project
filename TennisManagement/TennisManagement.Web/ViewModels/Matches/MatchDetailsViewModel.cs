using TennisManagement.Web.Models.Matches.MatchEnumerations;

namespace TennisManagement.Web.ViewModels.Matches
{
    public class MatchDetailsViewModel 
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

        public int VenueId { get; set; }

        public string VenueName { get; set; } = string.Empty;

        public int TournamentId { get; set; } 

        public string TournamentName { get; set; } = string.Empty;

        public int FirstPlayerId { get; set; } 

        public string FirstPlayerFullName { get; set; } = string.Empty;

        public int SecondPlayerId { get; set; } 

        public string SecondPlayerFullName { get; set; } = string.Empty;

        public int? WinnerId { get; set; } 

        public string? WinnerFullName { get; set; }

        public bool IsCompleted => this.MatchStatus == MatchStatus.Completed;
    }
}
