using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRM.Data.Migrations
{
    public partial class SeedDatall : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PizzaCrust",
                columns: new[] { "Id", "Active", "CreatedAt", "CreatedBy", "CreatedByName", "CrustType", "Deleted", "PizzaId", "UpdatedAt", "UpdatedBy", "UpdatedByName" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2022, 4, 11, 20, 32, 51, 502, DateTimeKind.Utc).AddTicks(5135), 1, null, 0, false, 1, null, 0, null },
                    { 2, true, new DateTime(2022, 4, 11, 20, 32, 51, 502, DateTimeKind.Utc).AddTicks(5539), 1, null, 1, false, 2, null, 0, null },
                    { 3, true, new DateTime(2022, 4, 11, 20, 32, 51, 502, DateTimeKind.Utc).AddTicks(5563), 1, null, 3, false, 3, null, 0, null },
                    { 4, true, new DateTime(2022, 4, 11, 20, 32, 51, 502, DateTimeKind.Utc).AddTicks(5565), 1, null, 2, false, 4, null, 0, null }
                });

            migrationBuilder.UpdateData(
                table: "PizzaMasterMenu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 11, 20, 32, 51, 504, DateTimeKind.Utc).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "PizzaMasterMenu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 11, 20, 32, 51, 504, DateTimeKind.Utc).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "PizzaMasterMenu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 11, 20, 32, 51, 504, DateTimeKind.Utc).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "PizzaMasterMenu",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 11, 20, 32, 51, 504, DateTimeKind.Utc).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PizzaId" },
                values: new object[] { new DateTime(2022, 4, 11, 20, 32, 51, 506, DateTimeKind.Utc).AddTicks(5513), 2 });

            migrationBuilder.UpdateData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PizzaId" },
                values: new object[] { new DateTime(2022, 4, 11, 20, 32, 51, 506, DateTimeKind.Utc).AddTicks(5514), 2 });

            migrationBuilder.UpdateData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PizzaId" },
                values: new object[] { new DateTime(2022, 4, 11, 20, 32, 51, 506, DateTimeKind.Utc).AddTicks(5515), 2 });

            migrationBuilder.InsertData(
                table: "PizzaSize",
                columns: new[] { "Id", "Active", "CreatedAt", "CreatedBy", "CreatedByName", "Deleted", "PizzaId", "SizeType", "UpdatedAt", "UpdatedBy", "UpdatedByName" },
                values: new object[,]
                {
                    { 6, true, new DateTime(2022, 4, 11, 20, 32, 51, 506, DateTimeKind.Utc).AddTicks(5519), 1, null, false, 3, 0, null, 0, null },
                    { 7, true, new DateTime(2022, 4, 11, 20, 32, 51, 506, DateTimeKind.Utc).AddTicks(5520), 1, null, false, 4, 2, null, 0, null },
                    { 8, true, new DateTime(2022, 4, 11, 20, 32, 51, 506, DateTimeKind.Utc).AddTicks(5521), 1, null, false, 4, 1, null, 0, null },
                    { 9, true, new DateTime(2022, 4, 11, 20, 32, 51, 506, DateTimeKind.Utc).AddTicks(5522), 1, null, false, 4, 0, null, 0, null },
                    { 10, true, new DateTime(2022, 4, 11, 20, 32, 51, 506, DateTimeKind.Utc).AddTicks(5317), 1, null, false, 1, 2, null, 0, null },
                    { 11, true, new DateTime(2022, 4, 11, 20, 32, 51, 506, DateTimeKind.Utc).AddTicks(5504), 1, null, false, 1, 1, null, 0, null },
                    { 4, true, new DateTime(2022, 4, 11, 20, 32, 51, 506, DateTimeKind.Utc).AddTicks(5516), 1, null, false, 3, 2, null, 0, null },
                    { 5, true, new DateTime(2022, 4, 11, 20, 32, 51, 506, DateTimeKind.Utc).AddTicks(5517), 1, null, false, 3, 1, null, 0, null }
                });

            migrationBuilder.InsertData(
                table: "PizzaToppings",
                columns: new[] { "Id", "Active", "CreatedAt", "CreatedBy", "CreatedByName", "Deleted", "PizzaId", "ToppingType", "UpdatedAt", "UpdatedBy", "UpdatedByName" },
                values: new object[,]
                {
                    { 12, true, new DateTime(2022, 4, 11, 20, 32, 51, 508, DateTimeKind.Utc).AddTicks(2546), 1, null, false, 4, 1, null, 0, null },
                    { 11, true, new DateTime(2022, 4, 11, 20, 32, 51, 508, DateTimeKind.Utc).AddTicks(2545), 1, null, false, 4, 2, null, 0, null },
                    { 8, true, new DateTime(2022, 4, 11, 20, 32, 51, 508, DateTimeKind.Utc).AddTicks(2540), 1, null, false, 3, 2, null, 0, null },
                    { 9, true, new DateTime(2022, 4, 11, 20, 32, 51, 508, DateTimeKind.Utc).AddTicks(2543), 1, null, false, 3, 0, null, 0, null },
                    { 7, true, new DateTime(2022, 4, 11, 20, 32, 51, 508, DateTimeKind.Utc).AddTicks(2539), 1, null, false, 3, 3, null, 0, null },
                    { 6, true, new DateTime(2022, 4, 11, 20, 32, 51, 508, DateTimeKind.Utc).AddTicks(2538), 1, null, false, 2, 0, null, 0, null },
                    { 5, true, new DateTime(2022, 4, 11, 20, 32, 51, 508, DateTimeKind.Utc).AddTicks(2537), 1, null, false, 2, 1, null, 0, null },
                    { 3, true, new DateTime(2022, 4, 11, 20, 32, 51, 508, DateTimeKind.Utc).AddTicks(2534), 1, null, false, 1, 0, null, 0, null },
                    { 2, true, new DateTime(2022, 4, 11, 20, 32, 51, 508, DateTimeKind.Utc).AddTicks(2524), 1, null, false, 1, 2, null, 0, null },
                    { 1, true, new DateTime(2022, 4, 11, 20, 32, 51, 508, DateTimeKind.Utc).AddTicks(2327), 1, null, false, 1, 5, null, 0, null },
                    { 10, true, new DateTime(2022, 4, 11, 20, 32, 51, 508, DateTimeKind.Utc).AddTicks(2544), 1, null, false, 4, 6, null, 0, null },
                    { 4, true, new DateTime(2022, 4, 11, 20, 32, 51, 508, DateTimeKind.Utc).AddTicks(2536), 1, null, false, 2, 2, null, 0, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PizzaCrust",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PizzaCrust",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PizzaCrust",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PizzaCrust",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "PizzaMasterMenu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "PizzaMasterMenu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "PizzaMasterMenu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "PizzaMasterMenu",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PizzaId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PizzaId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PizzaId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });
        }
    }
}
