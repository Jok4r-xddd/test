using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProject.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class ExtendedUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4373316b-aa73-43f4-8f05-84a9cd372250",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c949ac7a-19f0-408d-a2ac-6137f74b1bbd", new DateOnly(2000, 12, 12), "Default", "Admin", "AQAAAAIAAYagAAAAEO+RIsHEnqGCj3eZ1HmT2yusY5MplwVpF4o0clNxtQWhMQWKsHe+INOx7xOtBLx8xw==", "3fa05b59-7487-425f-b8c2-37d7290bba8c" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4373316b-aa73-43f4-8f05-84a9cd372250",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0ed64e5-64f4-4a57-bbba-c8a29037d5f1", "AQAAAAIAAYagAAAAEHDHQdgepMctsNKQJmz3C6pWtSCiwu7R8T6Y6asQu8HQ8OurnrX1P2oRucwxvLxADg==", "a9d8488c-2047-4749-af87-40627acaf224" });
        }
    }
}
