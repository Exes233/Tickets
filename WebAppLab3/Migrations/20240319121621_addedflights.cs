using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppLab3.Migrations
{
    public partial class addedflights : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seats_Flights_FlightId",
                table: "Seats");

            migrationBuilder.AlterColumn<int>(
                name: "FlightId",
                table: "Seats",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "ContactUsEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2024, 3, 19, 14, 16, 20, 906, DateTimeKind.Local).AddTicks(3580));

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "Description", "ImagePath", "Name" },
                values: new object[] { 1, "Explore the romantic charm of the City of Lights, visit iconic landmarks like the Eiffel Tower, and indulge in exquisite French cuisine.", "/images/paris.jpg", "Paris" });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 1, 1, false, "A1", 250 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 2, 1, false, "A2", 250 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 3, 1, false, "A3", 250 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 4, 1, false, "A4", 250 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 5, 1, false, "A5", 250 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 6, 1, false, "A6", 250 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 7, 1, false, "A7", 250 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 8, 1, false, "A8", 250 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 9, 1, false, "A9", 250 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 10, 1, false, "A10", 250 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 11, 1, false, "A11", 250 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 12, 1, false, "A12", 250 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 13, 1, false, "A13", 250 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 14, 1, false, "A14", 250 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 15, 1, false, "A15", 250 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 16, 1, false, "A16", 250 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 17, 1, false, "A17", 250 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 18, 1, false, "A18", 250 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 19, 1, false, "A19", 250 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 20, 1, false, "A20", 250 });

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_Flights_FlightId",
                table: "Seats",
                column: "FlightId",
                principalTable: "Flights",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seats_Flights_FlightId",
                table: "Seats");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "FlightId",
                table: "Seats",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.UpdateData(
                table: "ContactUsEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2024, 3, 19, 13, 20, 24, 463, DateTimeKind.Local).AddTicks(3984));

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_Flights_FlightId",
                table: "Seats",
                column: "FlightId",
                principalTable: "Flights",
                principalColumn: "Id");
        }
    }
}
