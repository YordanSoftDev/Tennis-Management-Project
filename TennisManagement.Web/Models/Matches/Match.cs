using TennisManagement.Web.Models.Matches.MatchEnumerations;
using TennisManagement.Web.Models.Roster;
using TennisManagement.Web.Models.Tournaments;

namespace TennisManagement.Web.Models.Matches
{
    public class Match
    {
        public int Id { get; set; }

        public DateTime DateTime { get; set; }

        public required string CourtName { get; set; }

        //The variants are Grass, Clay, Hard and Carpet
        public required CourtType CourtType { get; set; }

        //The variants are Singles, Doubles, Mixed
        public required MatchFormat MatchFormat { get; set; }

        //The variants are Frendly or Official
        public required MatchKind MatchKind { get; set; }

        public string? ScoreResult { get; set; }

        public int? DurationMinutes { get; set; }

        //The variants are sheduled or completed
        public MatchStatus MatchStatus { get; set; } = MatchStatus.Scheduled;

        //The venue(country and the tennis club or a stadium)
        //where the match will be played or was played
        public int VenueId { get; set; }

        public virtual Venue Venue { get; set; } = null!;

        public int TournamentId { get; set; }

        public virtual Tournament Tournament { get; set; } = null!;

        public int FirstPlayerId { get; set; }

        public virtual Player FirstPlayer { get; set; } = null!;

        public int SecondPlayerId { get; set; }

        public virtual Player SecondPlayer { get; set; } = null!;

        public int? WinnerId { get; set; }

        public virtual Player? Winner { get; set; }
    }
}
