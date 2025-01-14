using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyProject.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDefaulRolesAndUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0d78be45-ee3d-40cd-926c-049c72ed9aac", null, "Supervisor", "SUPERVISOR" },
                    { "1253f537-2c3b-435f-8520-951cc426788e", null, "Employee", "EMPLOYEE" },
                    { "6b6c1a31-66a6-479b-9a7e-0754fbd4340d", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4373316b-aa73-43f4-8f05-84a9cd372250", 0, "b0ed64e5-64f4-4a57-bbba-c8a29037d5f1", "admin@localhost.com", true, false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEHDHQdgepMctsNKQJmz3C6pWtSCiwu7R8T6Y6asQu8HQ8OurnrX1P2oRucwxvLxADg==", null, false, "a9d8488c-2047-4749-af87-40627acaf224", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6b6c1a31-66a6-479b-9a7e-0754fbd4340d", "4373316b-aa73-43f4-8f05-84a9cd372250" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d78be45-ee3d-40cd-926c-049c72ed9aac");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1253f537-2c3b-435f-8520-951cc426788e");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6b6c1a31-66a6-479b-9a7e-0754fbd4340d", "4373316b-aa73-43f4-8f05-84a9cd372250" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b6c1a31-66a6-479b-9a7e-0754fbd4340d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4373316b-aa73-43f4-8f05-84a9cd372250");
        }
    }
}
