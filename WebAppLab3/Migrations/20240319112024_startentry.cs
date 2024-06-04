using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppLab3.Migrations
{
    public partial class startentry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ContactUsEntries",
                columns: new[] { "Id", "Email", "Message", "Timestamp" },
                values: new object[] { 1, "test@gmail.com", "Hello", new DateTime(2024, 3, 19, 13, 20, 24, 463, DateTimeKind.Local).AddTicks(3984) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContactUsEntries",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
