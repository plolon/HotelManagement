using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagement.Infrastructure.Migrations
{
    public partial class Dupa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookingId",
                table: "ApplicationUsers",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a986fb26-1e37-49f8-b7c6-363d5b1be4b9",
                column: "ConcurrencyStamp",
                value: "b8fb7f36-aae3-474a-b32a-faacb90e564b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b693c6bd-3b96-4403-ad5c-f3c773d504d9",
                column: "ConcurrencyStamp",
                value: "18c953b9-38fa-4a46-907a-01199e248184");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f94000ea-05fe-43da-a5d3-64b2d646c9dc",
                column: "ConcurrencyStamp",
                value: "80050a58-a53c-4c72-9087-b59f9403478a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "182f77d7-964e-468a-8c13-8c0118287ca3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43c3d108-85ba-4e70-ae04-f3361c1d4235", "AQAAAAEAACcQAAAAEAvu6pr41hM/EWNT88kIQVKYRnKpkKkn5nDeLX9rM3AnTDZ5LG+PfCUsP13OXDwbVQ==", "34e0b149-0234-4e0f-bff7-197725abb5c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7f5923af-d1b4-41ce-8db8-cef9863ac90b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "374cb7ae-b133-4a17-8767-5182d981ef75", "AQAAAAEAACcQAAAAEKByxY6V/aEnrQyDbbagkQjgf1h0JTyzrwnciAboVtr8CgRnrNA60KrqU3KRcsk1VA==", "4b2fd769-2950-4194-8330-82f8da168a32" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d76c6509-a64a-4c53-a650-1ab645b7dab9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f10e463-3ff3-4c86-996c-95aea5f79f9e", "AQAAAAEAACcQAAAAEHfZC+t6m1pZUYJDTLv/jUo/Aa47y1xbDz0BMR5Zwzbmq9P9WvLuREDQBv5tEXJ9pw==", "fafe31e5-1a34-4e59-ba31-80c3afc6bd0f" });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUsers_BookingId",
                table: "ApplicationUsers",
                column: "BookingId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUsers_Bookings_BookingId",
                table: "ApplicationUsers",
                column: "BookingId",
                principalTable: "Bookings",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUsers_Bookings_BookingId",
                table: "ApplicationUsers");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationUsers_BookingId",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "BookingId",
                table: "ApplicationUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a986fb26-1e37-49f8-b7c6-363d5b1be4b9",
                column: "ConcurrencyStamp",
                value: "bf1efac3-983a-42d9-8fec-218b98934d99");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b693c6bd-3b96-4403-ad5c-f3c773d504d9",
                column: "ConcurrencyStamp",
                value: "00a13e0b-ec17-4289-a9ab-2ee624337402");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f94000ea-05fe-43da-a5d3-64b2d646c9dc",
                column: "ConcurrencyStamp",
                value: "fe19ccfd-b0ee-4fec-9747-c4d3d7145f49");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "182f77d7-964e-468a-8c13-8c0118287ca3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7094556f-fa62-42a1-a365-f5a03569900c", "AQAAAAEAACcQAAAAEJLmz+KxFK4JRLAM1yadEc/7UfFKBpNF8GLPIFaPzIyU7wKy8iSn/GuKq8GCpkmDdQ==", "e38947ba-84c9-40d3-900a-623e164f9a7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7f5923af-d1b4-41ce-8db8-cef9863ac90b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b064bc2-7b61-41ab-96cc-8bf10a381366", "AQAAAAEAACcQAAAAED7P1lN2YJXF2+gEvKw8UADMt4MG0gZ5p9salCnav0AGnpDedjfvWabTsuVpCxPB9Q==", "bba1b54f-7132-4a0f-bba4-a9d3450b6343" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d76c6509-a64a-4c53-a650-1ab645b7dab9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a0b5b4d-0b47-4787-a6ef-60e4c916f789", "AQAAAAEAACcQAAAAEKD93XA/de4WjwiR5BxH2hcJcyUtYpkPziA7GyWwomU5syXCjYORgRwJ5B25xmGr5A==", "d8724d50-8a5f-470e-9d0f-4cfa8419a1b6" });
        }
    }
}
