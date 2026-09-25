namespace TennisManagement.Web.Models.Roster
{
    public class Player
    {
        public int Id { get; set; }

        public required string FirstName { get; set; }

        public required string LastName { get; set; }

        public required int Age { get; set; }

        //example 170 lbs (77kg)
        public required string Weight { get; set; }

        //example 6'3" (191cm)
        public required string Height { get; set; }

        public required string Country { get; set; }

        public required string Birthplace { get; set; }

        public required string Coach { get; set; }
    }
}
