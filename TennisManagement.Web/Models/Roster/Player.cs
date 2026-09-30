namespace TennisManagement.Web.Models.Roster
{
    using TennisManagement.Web.Models.Country;
    public class Player
    {
        public int Id { get; set; }

        public required string FirstName { get; set; }

        public required string LastName { get; set; }

        public required int Age { get; set; }

        //example value 170 lbs/(77kg)
        public required string Weight { get; set; }

        //example value 6'3"/(191cm)
        public required string Height { get; set; }

        public required int CountryId { get; set; } 

        public Country Country { get; set; } = null!;

        public required string Birthplace { get; set; }

        public ICollection<Coach> Coaches { get; set; } = new List<Coach>();
    }
}
