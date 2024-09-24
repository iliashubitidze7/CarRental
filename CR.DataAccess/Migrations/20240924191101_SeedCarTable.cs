using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CR.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedCarTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "EndDate", "Fuel", "ImageUrl", "Interior", "Mileage", "Model", "Price", "Seats", "StartingDate", "Transmission", "Type", "Year" },
                values: new object[,]
                {
                    { 1, new DateOnly(1, 1, 1), "Petrol", null, "leathar", "147", "Mercedes CLS 5.5", 100.0, "4", new DateOnly(1, 1, 1), "Auto", "Sedan", "2020" },
                    { 2, new DateOnly(1, 1, 1), "Petrol", null, "Fabric", "95", "Mazda 6 2.0", 70.0, "5", new DateOnly(1, 1, 1), "Auto", "Sedan", "2016" },
                    { 3, new DateOnly(1, 1, 1), "Petrol", null, "leathar", "112", "BMW X5 4.0", 90.0, "4", new DateOnly(1, 1, 1), "Manual", "Sedan", "2018" },
                    { 4, new DateOnly(1, 1, 1), "Diesel", null, "Fabric", "34", "Mecedes Viano 2.5", 120.0, "7", new DateOnly(1, 1, 1), "Auto", "Van", "2021" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
