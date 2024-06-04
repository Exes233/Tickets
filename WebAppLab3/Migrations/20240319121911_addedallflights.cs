using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppLab3.Migrations
{
    public partial class addedallflights : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ContactUsEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2024, 3, 19, 14, 19, 11, 467, DateTimeKind.Local).AddTicks(7731));

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "Description", "ImagePath", "Name" },
                values: new object[] { 2, "Immerse yourself in the vibrant energy of Tokyo, experience a blend of modernity and tradition, and discover the unique cultural wonders of Japan.", "/images/tokyo.jpg", "Tokyo" });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "Description", "ImagePath", "Name" },
                values: new object[] { 3, "Dive into the bustling metropolis of New York City, witness the dazzling lights of Times Square, and explore world-renowned attractions like Central Park and the Statue of Liberty.", "/images/new_york.jpg", "New York" });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "Description", "ImagePath", "Name" },
                values: new object[] { 4, "Embark on a journey to Rio de Janeiro, where the lively rhythm of samba meets stunning beaches, iconic landmarks like Christ the Redeemer, and the vibrant Carnival spirit.", "/images/rio.jpg", "Rio de Janeiro" });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 21, 2, false, "B1", 450 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 22, 2, false, "B2", 450 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 23, 2, false, "B3", 450 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 24, 2, false, "B4", 450 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 25, 2, false, "B5", 450 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 26, 2, false, "B6", 450 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 27, 2, false, "B7", 450 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 28, 2, false, "B8", 450 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 29, 2, false, "B9", 450 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 30, 2, false, "B10", 450 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 31, 2, false, "B11", 450 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 32, 2, false, "B12", 450 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 33, 2, false, "B13", 450 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 34, 2, false, "B14", 450 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 35, 2, false, "B15", 450 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 36, 3, false, "C1", 1050 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 37, 3, false, "C2", 1050 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 38, 3, false, "C3", 1050 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 39, 3, false, "C4", 1050 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 40, 3, false, "C5", 1050 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 41, 3, false, "C6", 1050 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 42, 3, false, "C7", 1050 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 43, 3, false, "C8", 1050 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 44, 3, false, "C9", 1050 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 45, 3, false, "C10", 1050 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 46, 3, false, "C11", 1050 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 47, 3, false, "C12", 1050 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 48, 3, false, "C13", 1050 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 49, 3, false, "C14", 1050 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 50, 3, false, "C15", 1050 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 51, 3, false, "C16", 1050 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 52, 3, false, "C17", 1050 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 53, 3, false, "C18", 1050 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 54, 3, false, "C19", 1050 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 55, 3, false, "C20", 1050 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 56, 4, false, "A1", 350 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 57, 4, false, "A2", 350 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 58, 4, false, "A3", 350 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 59, 4, false, "A4", 350 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 60, 4, false, "A5", 350 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 61, 4, false, "A6", 350 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 62, 4, false, "A7", 350 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 63, 4, false, "A8", 350 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 64, 4, false, "A9", 350 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "IsBooked", "Number", "Price" },
                values: new object[] { 65, 4, false, "A10", 350 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "ContactUsEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2024, 3, 19, 14, 16, 20, 906, DateTimeKind.Local).AddTicks(3580));
        }
    }
}
