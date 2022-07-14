using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OfficeEntity.Migrations
{
    public partial class MaxLengthDescriptionAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 5);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "ClientId", "BirthDate", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "first@gmail.com", "First", "Firsty" },
                    { 2, new DateTime(2000, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "2@gmail.com", "Second", "Secondy" },
                    { 3, new DateTime(2000, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "3@gmail.com", "3", "3y" },
                    { 4, new DateTime(2000, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "4@gmail.com", "4", "4y" },
                    { 5, new DateTime(2000, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "5@gmail.com", "five", "5" }
                });
        }
    }
}
