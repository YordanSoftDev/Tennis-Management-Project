using System.ComponentModel.DataAnnotations;

namespace TennisManagement.Common.Matches.MatchEnumerations
{
    public enum MatchStatus
    {
        Scheduled = 0,
        [Display(Name = "In Progress")]
        InProgress = 1,
        Completed = 2,
        Cancelled = 3,
    }
}
