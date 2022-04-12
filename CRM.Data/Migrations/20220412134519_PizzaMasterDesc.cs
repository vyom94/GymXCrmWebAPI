using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRM.Data.Migrations
{
    public partial class PizzaMasterDesc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "PizzaMasterMenu",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "PizzaMasterMenu",
                maxLength: 250,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "PizzaCrust",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 13, 45, 18, 808, DateTimeKind.Utc).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "PizzaCrust",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 13, 45, 18, 808, DateTimeKind.Utc).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "PizzaCrust",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 13, 45, 18, 808, DateTimeKind.Utc).AddTicks(991));

            migrationBuilder.UpdateData(
                table: "PizzaCrust",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 13, 45, 18, 808, DateTimeKind.Utc).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "PizzaMasterMenu",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "ImageUrl" },
                values: new object[] { new DateTime(2022, 4, 12, 13, 45, 18, 810, DateTimeKind.Utc).AddTicks(4015), "Classic delight with 100% real mozzarella cheese", "https://images.dominos.co.in/farmhouse.png" });

            migrationBuilder.UpdateData(
                table: "PizzaMasterMenu",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "ImageUrl" },
                values: new object[] { new DateTime(2022, 4, 12, 13, 45, 18, 810, DateTimeKind.Utc).AddTicks(4320), "Delightful combination of onion, capsicum, tomato & grilled mushroom", "https://images.dominos.co.in/new_veggie_paradise.jpg" });

            migrationBuilder.UpdateData(
                table: "PizzaMasterMenu",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "ImageUrl" },
                values: new object[] { new DateTime(2022, 4, 12, 13, 45, 18, 810, DateTimeKind.Utc).AddTicks(4333), "American classic! Spicy, herbed chicken sausage on pizza", "https://images.dominos.co.in/new_pepper_barbeque_chicken.jpg" });

            migrationBuilder.UpdateData(
                table: "PizzaMasterMenu",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "ImageUrl" },
                values: new object[] { new DateTime(2022, 4, 12, 13, 45, 18, 810, DateTimeKind.Utc).AddTicks(4334), "Pepper barbecue chicken for that extra zing", "https://images.dominos.co.in/new_peppy_paneer.jpg" });

            migrationBuilder.UpdateData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 13, 45, 18, 812, DateTimeKind.Utc).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 13, 45, 18, 812, DateTimeKind.Utc).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 13, 45, 18, 812, DateTimeKind.Utc).AddTicks(5349));

            migrationBuilder.UpdateData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 13, 45, 18, 812, DateTimeKind.Utc).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 13, 45, 18, 812, DateTimeKind.Utc).AddTicks(5351));

            migrationBuilder.UpdateData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 13, 45, 18, 812, DateTimeKind.Utc).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 13, 45, 18, 812, DateTimeKind.Utc).AddTicks(5353));

            migrationBuilder.UpdateData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 13, 45, 18, 812, DateTimeKind.Utc).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 13, 45, 18, 812, DateTimeKind.Utc).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 13, 45, 18, 812, DateTimeKind.Utc).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 13, 45, 18, 812, DateTimeKind.Utc).AddTicks(5323));

            migrationBuilder.UpdateData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 13, 45, 18, 814, DateTimeKind.Utc).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 13, 45, 18, 814, DateTimeKind.Utc).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 13, 45, 18, 814, DateTimeKind.Utc).AddTicks(1927));

            migrationBuilder.UpdateData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 13, 45, 18, 814, DateTimeKind.Utc).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 13, 45, 18, 814, DateTimeKind.Utc).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 13, 45, 18, 814, DateTimeKind.Utc).AddTicks(1931));

            migrationBuilder.UpdateData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 13, 45, 18, 814, DateTimeKind.Utc).AddTicks(1932));

            migrationBuilder.UpdateData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 13, 45, 18, 814, DateTimeKind.Utc).AddTicks(1933));

            migrationBuilder.UpdateData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 13, 45, 18, 814, DateTimeKind.Utc).AddTicks(1934));

            migrationBuilder.UpdateData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 13, 45, 18, 814, DateTimeKind.Utc).AddTicks(1936));

            migrationBuilder.UpdateData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 13, 45, 18, 814, DateTimeKind.Utc).AddTicks(1937));

            migrationBuilder.UpdateData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 13, 45, 18, 814, DateTimeKind.Utc).AddTicks(1938));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "PizzaMasterMenu");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "PizzaMasterMenu");

            migrationBuilder.UpdateData(
                table: "PizzaCrust",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 11, 20, 32, 51, 502, DateTimeKind.Utc).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "PizzaCrust",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 11, 20, 32, 51, 502, DateTimeKind.Utc).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "PizzaCrust",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 11, 20, 32, 51, 502, DateTimeKind.Utc).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "PizzaCrust",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 11, 20, 32, 51, 502, DateTimeKind.Utc).AddTicks(5565));

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
                column: "CreatedAt",
                value: new DateTime(2022, 4, 11, 20, 32, 51, 506, DateTimeKind.Utc).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 11, 20, 32, 51, 506, DateTimeKind.Utc).AddTicks(5514));

            migrationBuilder.UpdateData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 11, 20, 32, 51, 506, DateTimeKind.Utc).AddTicks(5515));

            migrationBuilder.UpdateData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 11, 20, 32, 51, 506, DateTimeKind.Utc).AddTicks(5516));

            migrationBuilder.UpdateData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 11, 20, 32, 51, 506, DateTimeKind.Utc).AddTicks(5517));

            migrationBuilder.UpdateData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 11, 20, 32, 51, 506, DateTimeKind.Utc).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 11, 20, 32, 51, 506, DateTimeKind.Utc).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 11, 20, 32, 51, 506, DateTimeKind.Utc).AddTicks(5521));

            migrationBuilder.UpdateData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 11, 20, 32, 51, 506, DateTimeKind.Utc).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 11, 20, 32, 51, 506, DateTimeKind.Utc).AddTicks(5317));

            migrationBuilder.UpdateData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 11, 20, 32, 51, 506, DateTimeKind.Utc).AddTicks(5504));

            migrationBuilder.UpdateData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 11, 20, 32, 51, 508, DateTimeKind.Utc).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 11, 20, 32, 51, 508, DateTimeKind.Utc).AddTicks(2524));

            migrationBuilder.UpdateData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 11, 20, 32, 51, 508, DateTimeKind.Utc).AddTicks(2534));

            migrationBuilder.UpdateData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 11, 20, 32, 51, 508, DateTimeKind.Utc).AddTicks(2536));

            migrationBuilder.UpdateData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 11, 20, 32, 51, 508, DateTimeKind.Utc).AddTicks(2537));

            migrationBuilder.UpdateData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 11, 20, 32, 51, 508, DateTimeKind.Utc).AddTicks(2538));

            migrationBuilder.UpdateData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 11, 20, 32, 51, 508, DateTimeKind.Utc).AddTicks(2539));

            migrationBuilder.UpdateData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 11, 20, 32, 51, 508, DateTimeKind.Utc).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 11, 20, 32, 51, 508, DateTimeKind.Utc).AddTicks(2543));

            migrationBuilder.UpdateData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 11, 20, 32, 51, 508, DateTimeKind.Utc).AddTicks(2544));

            migrationBuilder.UpdateData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 11, 20, 32, 51, 508, DateTimeKind.Utc).AddTicks(2545));

            migrationBuilder.UpdateData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 11, 20, 32, 51, 508, DateTimeKind.Utc).AddTicks(2546));
        }
    }
}
