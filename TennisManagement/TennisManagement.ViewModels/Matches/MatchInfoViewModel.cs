namespace TennisManagement.ViewModels.Matches
{
    using TennisManagement.Common.Matches.MatchEnumerations;

    public class MatchInfoViewModel
    {
        public int Id { get; set; }

        public int FirstPlayerId { get; set; }

        public string FirstPlayerFullName { get; set; } = string.Empty;

        public int SecondPlayerId { get; set; }

        public string SecondPlayerFullName { get; set; } = string.Empty;

        public DateTime DateTime { get; set; }

        public MatchStatus MatchStatus { get; set; }

        public CourtType CourtType { get; set; }

        public string CourtName { get; set; } = string.Empty;

        public int VenueId { get; set; }

        public string VenueName { get; set; } = string.Empty;

        public int TournamentId { get; set; }

        public string TournamentName { get; set; } = string.Empty;
        
        public string? ScoreResult { get; set; }

        public int? WinnerId { get; set; }

        public string? WinnerFullName { get; set; }

        public bool IsCompleted => this.MatchStatus == MatchStatus.Completed;
    }
}
