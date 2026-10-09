namespace TennisManagement.Data.Models.Roster
{
    public class Coach
    {
        public int Id { get; set; }

        public required int PlayerId { get; set; }

        public Player Player { get; set; } = null!;
    }
}
