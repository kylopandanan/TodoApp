using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoApp.Migrations
{
    public partial class customertabletodo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Description", "DueDate", "Status", "Title" },
                values: new object[] { 1, "For Birthday", new DateTime(2023, 3, 17, 13, 27, 54, 745, DateTimeKind.Local).AddTicks(9546), false, "Shopping" });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Description", "DueDate", "Status", "Title" },
                values: new object[] { 2, "In Jump Trainin", new DateTime(2023, 3, 18, 13, 27, 54, 745, DateTimeKind.Local).AddTicks(9581), false, "Learn C#" });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Description", "DueDate", "Status", "Title" },
                values: new object[] { 3, "In Jump Trainin", new DateTime(2023, 3, 18, 13, 27, 54, 745, DateTimeKind.Local).AddTicks(9582), false, "Learn MSSQL" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
