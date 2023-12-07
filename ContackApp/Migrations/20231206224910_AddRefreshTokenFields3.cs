using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ContackApp.Migrations
{
    /// <inheritdoc />
    public partial class AddRefreshTokenFields3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "097fa892-af8e-426a-9440-89354bfdba58");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62f33908-cbf3-428f-ac35-a17a5ac126fd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe545ab6-708f-410c-939b-8a4d167fadb0");

            migrationBuilder.RenameColumn(
                name: "RefrshToken",
                table: "AspNetUsers",
                newName: "RefreshToken");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7c576c71-d44f-485c-9314-eb36db77368e", null, "Editor", "EDITOR" },
                    { "a2e07a48-f47c-45c6-972f-df0cece2468e", null, "User", "USER" },
                    { "e5688523-0bf7-4ab1-a580-eed56e3a31c6", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c576c71-d44f-485c-9314-eb36db77368e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2e07a48-f47c-45c6-972f-df0cece2468e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5688523-0bf7-4ab1-a580-eed56e3a31c6");

            migrationBuilder.RenameColumn(
                name: "RefreshToken",
                table: "AspNetUsers",
                newName: "RefrshToken");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "097fa892-af8e-426a-9440-89354bfdba58", null, "Admin", "ADMIN" },
                    { "62f33908-cbf3-428f-ac35-a17a5ac126fd", null, "User", "USER" },
                    { "fe545ab6-708f-410c-939b-8a4d167fadb0", null, "Editor", "EDITOR" }
                });
        }
    }
}
