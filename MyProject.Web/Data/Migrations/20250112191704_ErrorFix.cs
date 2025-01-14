using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProject.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class ErrorFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4373316b-aa73-43f4-8f05-84a9cd372250",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bfe0d9ea-0c7b-4149-b092-7495b740c26d", "AQAAAAIAAYagAAAAEGva6NCxjuaadeX5m0U8ku0GZh32ewR/VwtwhtMPjtFgeVewn5+s5ofosPHkzDQdDQ==", "d599feba-c8f5-4066-ab28-66045d2c10bb" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4373316b-aa73-43f4-8f05-84a9cd372250",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c949ac7a-19f0-408d-a2ac-6137f74b1bbd", "AQAAAAIAAYagAAAAEO+RIsHEnqGCj3eZ1HmT2yusY5MplwVpF4o0clNxtQWhMQWKsHe+INOx7xOtBLx8xw==", "3fa05b59-7487-425f-b8c2-37d7290bba8c" });
        }
    }
}
