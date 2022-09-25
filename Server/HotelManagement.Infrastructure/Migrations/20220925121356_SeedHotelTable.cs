using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagement.Infrastructure.Migrations
{
    public partial class SeedHotelTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "City", "Country", "DateCreated", "DateModified", "Name", "Street" },
                values: new object[] { 1, "Drezno", "Germany", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hotel1", "Danzigerstrasse 12" });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "City", "Country", "DateCreated", "DateModified", "Name", "Street" },
                values: new object[] { 2, "Cracow", "Poland", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hotel2", "Gertrudy 14" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
