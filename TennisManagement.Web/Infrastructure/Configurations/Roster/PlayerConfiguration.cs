using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TennisManagement.Web.Models.Roster;

namespace TennisManagement.Web.Infrastructure.Configurations.Roster
{
    public class PlayerConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.FirstName)
                .IsRequired(true);

            builder.Property(p => p.LastName)
                .IsRequired(true);

            builder.Property(p => p.Age)
                .IsRequired(true);

            builder.Property(p => p.Weight)
                .IsRequired(true);

            builder.Property(p => p.Height)
                .IsRequired(true);

            builder.Property(p => p.Birthplace)
                .IsRequired(true);

            builder.HasOne(p => p.Country)
                .WithMany()
                .HasForeignKey(p => p.CountryId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(p => p.Coaches)
                .WithOne(c => c.Player)
                .HasForeignKey(c => c.PlayerId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
    new Player
    {
        Id = 1,
        FirstName = "Novak",
        LastName = "Djokovic",
        Age = 36,
        Weight = "170 lbs/(77kg)",
        Height = "6'2\"/(188cm)",
        CountryId = 154, // Serbia
        Birthplace = "Belgrade, Serbia"
    },
    new Player
    {
        Id = 2,
        FirstName = "Carlos",
        LastName = "Alcaraz",
        Age = 20,
        Weight = "163 lbs/(74kg)",
        Height = "6'0\"/(183cm)",
        CountryId = 165, // Spain
        Birthplace = "El Palmar, Murcia, Spain"
    },
    new Player
    {
        Id = 3,
        FirstName = "Jannik",
        LastName = "Sinner",
        Age = 22,
        Weight = "168 lbs/(76kg)",
        Height = "6'3\"/(191cm)",
        CountryId = 84, // Italy
        Birthplace = "Innichen, Italy"
    },
    new Player
    {
        Id = 4,
        FirstName = "Daniil",
        LastName = "Medvedev",
        Age = 28,
        Weight = "183 lbs/(83kg)",
        Height = "6'6\"/(198cm)",
        CountryId = 114, // Monaco
        Birthplace = "Moscow, Russia"
    },
    new Player
    {
        Id = 5,
        FirstName = "Alexander",
        LastName = "Zverev",
        Age = 26,
        Weight = "198 lbs/(90kg)",
        Height = "6'6\"/(198cm)",
        CountryId = 65, // Germany
        Birthplace = "Hamburg, Germany"
    },
    new Player
    {
        Id = 6,
        FirstName = "Grigor",
        LastName = "Dimitrov",
        Age = 35,
        Weight = "178 lbs/(80kg)",
        Height = "6'3\"/(191cm)",
        CountryId = 26, // Bulgaria
        Birthplace = "Haskovo, Bulgaria"
    },
    new Player
    {
        Id = 7,
        FirstName = "Stefanos",
        LastName = "Tsitsipas",
        Age = 28,
        Weight = "198 lbs/(90kg)",
        Height = "6'4\"/(193cm)",
        CountryId = 67, // Greece
        Birthplace = "Athens, Greece"
    },
    new Player
    {
        Id = 8,
        FirstName = "Casper",
        LastName = "Ruud",
        Age = 27,
        Weight = "178 lbs/(81kg)",
        Height = "6'0\"/(183cm)",
        CountryId = 130, // Norway
        Birthplace = "Oslo, Norway"
    },
    new Player
    {
        Id = 9,
        FirstName = "Holger",
        LastName = "Rune",
        Age = 23,
        Weight = "169 lbs/(77kg)",
        Height = "6'2\"/(188cm)",
        CountryId = 47, // Denmark
        Birthplace = "Gentofte, Denmark"
    },
    new Player
    {
        Id = 10,
        FirstName = "Taylor",
        LastName = "Fritz",
        Age = 28,
        Weight = "185 lbs/(84kg)",
        Height = "6'5\"/(196cm)",
        CountryId = 187, // United States of America
        Birthplace = "Rancho Santa Fe, California, USA"
    },
    new Player
    {
        Id = 11,
        FirstName = "Alex",
        LastName = "de Minaur",
        Age = 27,
        Weight = "152 lbs/(69kg)",
        Height = "6'0\"/(183cm)",
        CountryId = 9, // Australia
        Birthplace = "Sydney, Australia"
    },
    new Player
    {
        Id = 12,
        FirstName = "Andrey",
        LastName = "Rublev",
        Age = 28,
        Weight = "165 lbs/(75kg)",
        Height = "6'2\"/(188cm)",
        CountryId = 144, // Russia
        Birthplace = "Moscow, Russia"
    },
    new Player
    {
        Id = 13,
        FirstName = "Hubert",
        LastName = "Hurkacz",
        Age = 29,
        Weight = "179 lbs/(81kg)",
        Height = "6'5\"/(196cm)",
        CountryId = 140, // Poland
        Birthplace = "Wroclaw, Poland"
    },
    new Player
    {
        Id = 14,
        FirstName = "Ben",
        LastName = "Shelton",
        Age = 23,
        Weight = "195 lbs/(88kg)",
        Height = "6'4\"/(193cm)",
        CountryId = 187, // United States of America
        Birthplace = "Atlanta, Georgia, USA"
    },
    new Player
    {
        Id = 15,
        FirstName = "Frances",
        LastName = "Tiafoe",
        Age = 28,
        Weight = "190 lbs/(86kg)",
        Height = "6'2\"/(188cm)",
        CountryId = 187, // United States of America
        Birthplace = "Hyattsville, Maryland, USA"
    },
    new Player
    {
        Id = 16,
        FirstName = "Ugo",
        LastName = "Humbert",
        Age = 28,
        Weight = "161 lbs/(73kg)",
        Height = "6'2\"/(188cm)",
        CountryId = 61, // France
        Birthplace = "Metz, France"
    },
    new Player
    {
        Id = 17,
        FirstName = "Sebastian",
        LastName = "Korda",
        Age = 26,
        Weight = "175 lbs/(79kg)",
        Height = "6'5\"/(196cm)",
        CountryId = 187, // United States of America
        Birthplace = "Bradenton, Florida, USA"
    },
    new Player
    {
        Id = 18,
        FirstName = "Lorenzo",
        LastName = "Musetti",
        Age = 24,
        Weight = "165 lbs/(75kg)",
        Height = "6'1\"/(185cm)",
        CountryId = 84, // Italy
        Birthplace = "Carrara, Italy"
    },
    new Player
    {
        Id = 19,
        FirstName = "Jack",
        LastName = "Draper",
        Age = 24,
        Weight = "187 lbs/(85kg)",
        Height = "6'4\"/(193cm)",
        CountryId = 186, // United Kingdom
        Birthplace = "Sutton, London, United Kingdom"
    },
    new Player
    {
        Id = 20,
        FirstName = "Felix",
        LastName = "Auger-Aliassime",
        Age = 26,
        Weight = "194 lbs/(88kg)",
        Height = "6'4\"/(193cm)",
        CountryId = 32, // Canada
        Birthplace = "Montreal, Canada"
    },
    new Player
    {
        Id = 21,
        FirstName = "Francisco",
        LastName = "Comesana",
        Age = 25,
        Weight = "165 lbs/(75kg)",
        Height = "5'10\"/(178cm)",
        CountryId = 7, // Argentina
        Birthplace = "Mar del Plata, Argentina"
    },
    new Player
    {
        Id = 22,
        FirstName = "Cameron",
        LastName = "Norrie",
        Age = 31,
        Weight = "180 lbs/(82kg)",
        Height = "6'2\"/(188cm)",
        CountryId = 186, // United Kingdom
        Birthplace = "Johannesburg, South Africa"
    },
    new Player
    {
        Id = 23,
        FirstName = "Stan",
        LastName = "Wawrinka",
        Age = 41,
        Weight = "179 lbs/(81kg)",
        Height = "6'0\"/(183cm)",
        CountryId = 170, // Switzerland
        Birthplace = "Lausanne, Switzerland"
    },
    new Player
    {
        Id = 24,
        FirstName = "Gaël",
        LastName = "Monfils",
        Age = 40,
        Weight = "187 lbs/(85kg)",
        Height = "6'4\"/(193cm)",
        CountryId = 61, // France
        Birthplace = "Paris, France"
    },
    new Player
    {
        Id = 25,
        FirstName = "Matteo",
        LastName = "Berrettini",
        Age = 30,
        Weight = "210 lbs/(95kg)",
        Height = "6'5\"/(196cm)",
        CountryId = 84, // Italy
        Birthplace = "Rome, Italy"
    },
    new Player
    {
        Id = 26,
        FirstName = "Karen",
        LastName = "Khachanov",
        Age = 30,
        Weight = "192 lbs/(87kg)",
        Height = "6'6\"/(198cm)",
        CountryId = 144, // Russia
        Birthplace = "Moscow, Russia"
    },
    new Player
    {
        Id = 27,
        FirstName = "Sebastian",
        LastName = "Baez",
        Age = 25,
        Weight = "154 lbs/(70kg)",
        Height = "5'7\"/(170cm)",
        CountryId = 7, // Argentina
        Birthplace = "Buenos Aires, Argentina"
    },
    new Player
    {
        Id = 28,
        FirstName = "Francisco",
        LastName = "Cerundolo",
        Age = 28,
        Weight = "172 lbs/(78kg)",
        Height = "6'1\"/(185cm)",
        CountryId = 7, // Argentina
        Birthplace = "Buenos Aires, Argentina"
    },
    new Player
    {
        Id = 29,
        FirstName = "Alejandro",
        LastName = "Tabilo",
        Age = 29,
        Weight = "165 lbs/(75kg)",
        Height = "6'2\"/(188cm)",
        CountryId = 35, // Chile
        Birthplace = "Toronto, Canada"
    },
    new Player
    {
        Id = 30,
        FirstName = "Nicolas",
        LastName = "Jarry",
        Age = 30,
        Weight = "198 lbs/(90kg)",
        Height = "6'7\"/(201cm)",
        CountryId = 35, // Chile
        Birthplace = "Santiago, Chile"
    },
    new Player
    {
        Id = 31,
        FirstName = "Tomas Martin",
        LastName = "Etcheverry",
        Age = 27,
        Weight = "181 lbs/(82kg)",
        Height = "6'5\"/(196cm)",
        CountryId = 7, // Argentina
        Birthplace = "La Plata, Argentina"
    },
    new Player
    {
        Id = 32,
        FirstName = "Arthur",
        LastName = "Fils",
        Age = 22,
        Weight = "183 lbs/(83kg)",
        Height = "6'1\"/(185cm)",
        CountryId = 61, // France
        Birthplace = "Courcouronnes, France"
    },
    new Player
    {
        Id = 33,
        FirstName = "Adrian",
        LastName = "Mannarino",
        Age = 38,
        Weight = "174 lbs/(79kg)",
        Height = "6'0\"/(183cm)",
        CountryId = 61, // France
        Birthplace = "Soisy-sous-Montmorency, France"
    },
    new Player
    {
        Id = 34,
        FirstName = "Jan-Lennard",
        LastName = "Struff",
        Age = 36,
        Weight = "203 lbs/(92kg)",
        Height = "6'4\"/(193cm)",
        CountryId = 65, // Germany
        Birthplace = "Warstein, Germany"
    },
    new Player
    {
        Id = 35,
        FirstName = "Jordan",
        LastName = "Thompson",
        Age = 32,
        Weight = "181 lbs/(82kg)",
        Height = "6'0\"/(183cm)",
        CountryId = 9, // Australia
        Birthplace = "Sydney, Australia"
    },
    new Player
    {
        Id = 36,
        FirstName = "Nuno",
        LastName = "Borges",
        Age = 29,
        Weight = "165 lbs/(75kg)",
        Height = "6'1\"/(185cm)",
        CountryId = 141, // Portugal
        Birthplace = "Maia, Portugal"
    },
    new Player
    {
        Id = 37,
        FirstName = "Fabian",
        LastName = "Marozsan",
        Age = 26,
        Weight = "165 lbs/(75kg)",
        Height = "6'4\"/(193cm)",
        CountryId = 76, // Hungary
        Birthplace = "Budapest, Hungary"
    },
    new Player
    {
        Id = 38,
        FirstName = "Alexei",
        LastName = "Popyrin",
        Age = 27,
        Weight = "172 lbs/(78kg)",
        Height = "6'5\"/(196cm)",
        CountryId = 9, // Australia
        Birthplace = "Sydney, Australia"
    },
    new Player
    {
        Id = 39,
        FirstName = "Matteo",
        LastName = "Arnaldi",
        Age = 25,
        Weight = "157 lbs/(71kg)",
        Height = "5'11\"/(180cm)",
        CountryId = 84, // Italy
        Birthplace = "Sanremo, Italy"
    },
    new Player
    {
        Id = 40,
        FirstName = "Giovanni",
        LastName = "Mpetshi Perricard",
        Age = 23,
        Weight = "216 lbs/(98kg)",
        Height = "6'8\"/(203cm)",
        CountryId = 61, // France
        Birthplace = "Lyon, France"
    }
);
        }
    }
}
