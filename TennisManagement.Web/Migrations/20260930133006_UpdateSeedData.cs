using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TennisManagement.Web.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "Birthplace", "CountryId", "FirstName", "Height", "LastName", "Weight" },
                values: new object[,]
                {
                    { 1, 36, "Belgrade, Serbia", 154, "Novak", "6'2\"/(188cm)", "Djokovic", "170 lbs/(77kg)" },
                    { 2, 20, "El Palmar, Murcia, Spain", 165, "Carlos", "6'0\"/(183cm)", "Alcaraz", "163 lbs/(74kg)" },
                    { 3, 22, "Innichen, Italy", 84, "Jannik", "6'3\"/(191cm)", "Sinner", "168 lbs/(76kg)" },
                    { 4, 28, "Moscow, Russia", 114, "Daniil", "6'6\"/(198cm)", "Medvedev", "183 lbs/(83kg)" },
                    { 5, 26, "Hamburg, Germany", 65, "Alexander", "6'6\"/(198cm)", "Zverev", "198 lbs/(90kg)" },
                    { 6, 35, "Haskovo, Bulgaria", 26, "Grigor", "6'3\"/(191cm)", "Dimitrov", "178 lbs/(80kg)" },
                    { 7, 28, "Athens, Greece", 67, "Stefanos", "6'4\"/(193cm)", "Tsitsipas", "198 lbs/(90kg)" },
                    { 8, 27, "Oslo, Norway", 130, "Casper", "6'0\"/(183cm)", "Ruud", "178 lbs/(81kg)" },
                    { 9, 23, "Gentofte, Denmark", 47, "Holger", "6'2\"/(188cm)", "Rune", "169 lbs/(77kg)" },
                    { 10, 28, "Rancho Santa Fe, California, USA", 187, "Taylor", "6'5\"/(196cm)", "Fritz", "185 lbs/(84kg)" },
                    { 11, 27, "Sydney, Australia", 9, "Alex", "6'0\"/(183cm)", "de Minaur", "152 lbs/(69kg)" },
                    { 12, 28, "Moscow, Russia", 144, "Andrey", "6'2\"/(188cm)", "Rublev", "165 lbs/(75kg)" },
                    { 13, 29, "Wroclaw, Poland", 140, "Hubert", "6'5\"/(196cm)", "Hurkacz", "179 lbs/(81kg)" },
                    { 14, 23, "Atlanta, Georgia, USA", 187, "Ben", "6'4\"/(193cm)", "Shelton", "195 lbs/(88kg)" },
                    { 15, 28, "Hyattsville, Maryland, USA", 187, "Frances", "6'2\"/(188cm)", "Tiafoe", "190 lbs/(86kg)" },
                    { 16, 28, "Metz, France", 61, "Ugo", "6'2\"/(188cm)", "Humbert", "161 lbs/(73kg)" },
                    { 17, 26, "Bradenton, Florida, USA", 187, "Sebastian", "6'5\"/(196cm)", "Korda", "175 lbs/(79kg)" },
                    { 18, 24, "Carrara, Italy", 84, "Lorenzo", "6'1\"/(185cm)", "Musetti", "165 lbs/(75kg)" },
                    { 19, 24, "Sutton, London, United Kingdom", 186, "Jack", "6'4\"/(193cm)", "Draper", "187 lbs/(85kg)" },
                    { 20, 26, "Montreal, Canada", 32, "Felix", "6'4\"/(193cm)", "Auger-Aliassime", "194 lbs/(88kg)" },
                    { 21, 25, "Mar del Plata, Argentina", 7, "Francisco", "5'10\"/(178cm)", "Comesana", "165 lbs/(75kg)" },
                    { 22, 31, "Johannesburg, South Africa", 186, "Cameron", "6'2\"/(188cm)", "Norrie", "180 lbs/(82kg)" },
                    { 23, 41, "Lausanne, Switzerland", 170, "Stan", "6'0\"/(183cm)", "Wawrinka", "179 lbs/(81kg)" },
                    { 24, 40, "Paris, France", 61, "Gaël", "6'4\"/(193cm)", "Monfils", "187 lbs/(85kg)" },
                    { 25, 30, "Rome, Italy", 84, "Matteo", "6'5\"/(196cm)", "Berrettini", "210 lbs/(95kg)" },
                    { 26, 30, "Moscow, Russia", 144, "Karen", "6'6\"/(198cm)", "Khachanov", "192 lbs/(87kg)" },
                    { 27, 25, "Buenos Aires, Argentina", 7, "Sebastian", "5'7\"/(170cm)", "Baez", "154 lbs/(70kg)" },
                    { 28, 28, "Buenos Aires, Argentina", 7, "Francisco", "6'1\"/(185cm)", "Cerundolo", "172 lbs/(78kg)" },
                    { 29, 29, "Toronto, Canada", 35, "Alejandro", "6'2\"/(188cm)", "Tabilo", "165 lbs/(75kg)" },
                    { 30, 30, "Santiago, Chile", 35, "Nicolas", "6'7\"/(201cm)", "Jarry", "198 lbs/(90kg)" },
                    { 31, 27, "La Plata, Argentina", 7, "Tomas Martin", "6'5\"/(196cm)", "Etcheverry", "181 lbs/(82kg)" },
                    { 32, 22, "Courcouronnes, France", 61, "Arthur", "6'1\"/(185cm)", "Fils", "183 lbs/(83kg)" },
                    { 33, 38, "Soisy-sous-Montmorency, France", 61, "Adrian", "6'0\"/(183cm)", "Mannarino", "174 lbs/(79kg)" },
                    { 34, 36, "Warstein, Germany", 65, "Jan-Lennard", "6'4\"/(193cm)", "Struff", "203 lbs/(92kg)" },
                    { 35, 32, "Sydney, Australia", 9, "Jordan", "6'0\"/(183cm)", "Thompson", "181 lbs/(82kg)" },
                    { 36, 29, "Maia, Portugal", 141, "Nuno", "6'1\"/(185cm)", "Borges", "165 lbs/(75kg)" },
                    { 37, 26, "Budapest, Hungary", 76, "Fabian", "6'4\"/(193cm)", "Marozsan", "165 lbs/(75kg)" },
                    { 38, 27, "Sydney, Australia", 9, "Alexei", "6'5\"/(196cm)", "Popyrin", "172 lbs/(78kg)" },
                    { 39, 25, "Sanremo, Italy", 84, "Matteo", "5'11\"/(180cm)", "Arnaldi", "157 lbs/(71kg)" },
                    { 40, 23, "Lyon, France", 61, "Giovanni", "6'8\"/(203cm)", "Mpetshi Perricard", "216 lbs/(98kg)" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 40);
        }
    }
}
