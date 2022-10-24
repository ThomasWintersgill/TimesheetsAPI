using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TimesheetsAPI.Data.Migrations
{
    public partial class addedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "BillingAddress", "CompanyName", "ContactEmail", "ContactName", "ContactTelephone" },
                values: new object[] { 1, "RedcarHighStreet", "Tesco", "John@gmail.com", "John", "07532564789" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationID", "Name", "address" },
                values: new object[] { 1, "Tesco", "Redcar" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 1);
        }
    }
}
