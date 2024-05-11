using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CMS.Migrations
{
    /// <inheritdoc />
    public partial class nuevosDatos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DataUsers",
                columns: new[] { "Data_Id", "CreatedDate", "Description", "Image", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 11, 19, 33, 41, 574, DateTimeKind.Local).AddTicks(4868), "Descripción 1", "imagen1.jpg", "Título 1" },
                    { 2, new DateTime(2024, 5, 11, 19, 33, 41, 574, DateTimeKind.Local).AddTicks(4957), "Descripción 2", "imagen2.jpg", "Título 2" },
                    { 3, new DateTime(2024, 5, 11, 19, 33, 41, 574, DateTimeKind.Local).AddTicks(4961), "Descripción 3", "imagen3.jpg", "Título 3" },
                    { 4, new DateTime(2024, 5, 11, 19, 33, 41, 574, DateTimeKind.Local).AddTicks(4965), "Descripción 4", "imagen4.jpg", "Título 4" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "User_Id", "Age", "Data_Id", "Email", "Name", "Password", "UserName" },
                values: new object[,]
                {
                    { 1, 25, 1, "usuario1@example.com", "Usuario 1", "password1", "user1" },
                    { 2, 30, 2, "usuario2@example.com", "Usuario 2", "password2", "user2" },
                    { 3, 35, 3, "usuario3@example.com", "Usuario 3", "password3", "user3" },
                    { 4, 40, 4, "usuario4@example.com", "Usuario 4", "password4", "user4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DataUsers",
                keyColumn: "Data_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DataUsers",
                keyColumn: "Data_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DataUsers",
                keyColumn: "Data_Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DataUsers",
                keyColumn: "Data_Id",
                keyValue: 4);
        }
    }
}
