namespace TennisManagement.Web.Models.Roster
{
    public class Player
    {
        public int Id { get; set; }

        public required string FirstName { get; set; }

        public required string SecondName { get; set; }

        public required string LastName { get; set; }
    }
}
