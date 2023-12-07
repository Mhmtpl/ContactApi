using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ContackApp.Migrations
{
    /// <inheritdoc />
    public partial class AddRolesToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "385a9591-c1ca-4445-a787-90e4f9a936d5", null, "Admin", "ADMIN" },
                    { "5804a5e3-8398-44bb-8d91-b74ec5f9662d", null, "User", "USER" },
                    { "fe6c1029-20f9-468e-b6f2-94e5d8d65c2b", null, "Editor", "EDITOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "385a9591-c1ca-4445-a787-90e4f9a936d5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5804a5e3-8398-44bb-8d91-b74ec5f9662d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe6c1029-20f9-468e-b6f2-94e5d8d65c2b");
        }
    }
}
