using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRM.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PizzaMasterMenu",
                columns: new[] { "Id", "Active", "CreatedAt", "CreatedBy", "CreatedByName", "Deleted", "Name", "UpdatedAt", "UpdatedBy", "UpdatedByName" },
                values: new object[,]
                {
                    { 1, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, false, "Chicken Tikka Pizza", null, 0, null },
                    { 2, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, false, "Veg Exotic Pizza", null, 0, null },
                    { 3, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, false, "Chilly Chicken Pizza", null, 0, null },
                    { 4, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, false, "Chilly Paneer Pizza", null, 0, null }
                });

            migrationBuilder.InsertData(
                table: "PizzaSize",
                columns: new[] { "Id", "Active", "CreatedAt", "CreatedBy", "CreatedByName", "Deleted", "PizzaId", "SizeType", "UpdatedAt", "UpdatedBy", "UpdatedByName" },
                values: new object[] { 1, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, false, 1, 2, null, 0, null });

            migrationBuilder.InsertData(
                table: "PizzaSize",
                columns: new[] { "Id", "Active", "CreatedAt", "CreatedBy", "CreatedByName", "Deleted", "PizzaId", "SizeType", "UpdatedAt", "UpdatedBy", "UpdatedByName" },
                values: new object[] { 2, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, false, 1, 1, null, 0, null });

            migrationBuilder.InsertData(
                table: "PizzaSize",
                columns: new[] { "Id", "Active", "CreatedAt", "CreatedBy", "CreatedByName", "Deleted", "PizzaId", "SizeType", "UpdatedAt", "UpdatedBy", "UpdatedByName" },
                values: new object[] { 3, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, false, 1, 0, null, 0, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PizzaMasterMenu",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PizzaMasterMenu",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PizzaMasterMenu",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PizzaMasterMenu",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
