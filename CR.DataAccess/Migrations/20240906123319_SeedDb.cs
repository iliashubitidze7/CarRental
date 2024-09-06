using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CR.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "EndDate", "Fuel", "Interior", "Model", "Price", "PriceFor8", "Seats", "StartingDate", "Transmission", "Type" },
                values: new object[,]
                {
                    { 1, new DateOnly(1, 1, 1), "Gasoline", "leathar", "Mercedes CLS 5.5 2020", 100.0, 80.0, "4", new DateOnly(1, 1, 1), "Authomatic", "Sedan" },
                    { 2, new DateOnly(1, 1, 1), "Gasoline", "Fabric", "Mazda 6 2.0 2016", 70.0, 50.0, "5", new DateOnly(1, 1, 1), "Authomatic", "Sedan" },
                    { 3, new DateOnly(1, 1, 1), "Gasoline", "leathar", "BMW X5 4.0 2018", 90.0, 70.0, "4", new DateOnly(1, 1, 1), "Mechanical", "Sedan" },
                    { 4, new DateOnly(1, 1, 1), "Diesel", "Fabric", "Mecedes Viano 2.5 2021", 120.0, 100.0, "7", new DateOnly(1, 1, 1), "Authomatic", "Van" }
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
