using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AzureWebApp.NetCore.Migrations
{
    /// <inheritdoc />
    public partial class AddDataDBScript : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "DateOfBirth", "FirstName", "LastName" },
                values: new object[] { 1, new DateTime(1984, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Parkar" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
