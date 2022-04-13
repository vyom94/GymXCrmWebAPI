using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRM.Data.Migrations
{
    public partial class PizzaPriceModifyAddV11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PizzaCrust_Master",
                table: "PizzaCrust");

            migrationBuilder.DropIndex(
                name: "IX_PizzaCrust_PizzaId",
                table: "PizzaCrust");

            migrationBuilder.AddColumn<int>(
                name: "PizzaMasterMenuId",
                table: "PizzaCrust",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CrustPrice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(maxLength: 25, nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(maxLength: 25, nullable: false),
                    UpdatedByName = table.Column<string>(nullable: true),
                    CrustType = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    PizzaCrustId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrustPrice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CrustPrice_PizzaCrust_PizzaCrustId",
                        column: x => x.PizzaCrustId,
                        principalTable: "PizzaCrust",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PizzaPrice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(maxLength: 25, nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(maxLength: 25, nullable: false),
                    UpdatedByName = table.Column<string>(nullable: true),
                    PizzaId = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PizzaPrice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PizzaPrice_Master",
                        column: x => x.PizzaId,
                        principalTable: "PizzaMasterMenu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ToppingsPrice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(maxLength: 25, nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(maxLength: 25, nullable: false),
                    UpdatedByName = table.Column<string>(nullable: true),
                    ToppingType = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToppingsPrice", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CrustPrice",
                columns: new[] { "Id", "Active", "CreatedAt", "CreatedBy", "CreatedByName", "CrustType", "Deleted", "PizzaCrustId", "Price", "UpdatedAt", "UpdatedBy", "UpdatedByName" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2022, 4, 12, 23, 17, 10, 538, DateTimeKind.Utc).AddTicks(8901), 1, null, 0, false, null, 10, null, 0, null },
                    { 2, true, new DateTime(2022, 4, 12, 23, 17, 10, 538, DateTimeKind.Utc).AddTicks(9267), 1, null, 1, false, null, 5, null, 0, null },
                    { 3, true, new DateTime(2022, 4, 12, 23, 17, 10, 538, DateTimeKind.Utc).AddTicks(9283), 1, null, 3, false, null, 7, null, 0, null },
                    { 4, true, new DateTime(2022, 4, 12, 23, 17, 10, 538, DateTimeKind.Utc).AddTicks(9285), 1, null, 2, false, null, 12, null, 0, null }
                });

            migrationBuilder.UpdateData(
                table: "PizzaCrust",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 23, 17, 10, 540, DateTimeKind.Utc).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "PizzaCrust",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 23, 17, 10, 540, DateTimeKind.Utc).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "PizzaCrust",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 23, 17, 10, 540, DateTimeKind.Utc).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "PizzaCrust",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 23, 17, 10, 540, DateTimeKind.Utc).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "PizzaMasterMenu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 23, 17, 10, 542, DateTimeKind.Utc).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "PizzaMasterMenu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 23, 17, 10, 542, DateTimeKind.Utc).AddTicks(2340));

            migrationBuilder.UpdateData(
                table: "PizzaMasterMenu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 23, 17, 10, 542, DateTimeKind.Utc).AddTicks(2362));

            migrationBuilder.UpdateData(
                table: "PizzaMasterMenu",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 23, 17, 10, 542, DateTimeKind.Utc).AddTicks(2363));

            migrationBuilder.InsertData(
                table: "PizzaPrice",
                columns: new[] { "Id", "Active", "CreatedAt", "CreatedBy", "CreatedByName", "Deleted", "PizzaId", "Price", "UpdatedAt", "UpdatedBy", "UpdatedByName" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2022, 4, 12, 23, 17, 10, 551, DateTimeKind.Utc).AddTicks(4752), 1, null, false, 1, 10, null, 0, null },
                    { 2, true, new DateTime(2022, 4, 12, 23, 17, 10, 551, DateTimeKind.Utc).AddTicks(4912), 1, null, false, 2, 12, null, 0, null },
                    { 4, true, new DateTime(2022, 4, 12, 23, 17, 10, 551, DateTimeKind.Utc).AddTicks(4920), 1, null, false, 4, 17, null, 0, null },
                    { 3, true, new DateTime(2022, 4, 12, 23, 17, 10, 551, DateTimeKind.Utc).AddTicks(4918), 1, null, false, 3, 15, null, 0, null }
                });

            migrationBuilder.UpdateData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 23, 17, 10, 553, DateTimeKind.Utc).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 23, 17, 10, 553, DateTimeKind.Utc).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 23, 17, 10, 553, DateTimeKind.Utc).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 23, 17, 10, 553, DateTimeKind.Utc).AddTicks(1723));

            migrationBuilder.UpdateData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 23, 17, 10, 553, DateTimeKind.Utc).AddTicks(1724));

            migrationBuilder.UpdateData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 23, 17, 10, 553, DateTimeKind.Utc).AddTicks(1725));

            migrationBuilder.UpdateData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 23, 17, 10, 553, DateTimeKind.Utc).AddTicks(1726));

            migrationBuilder.UpdateData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 23, 17, 10, 553, DateTimeKind.Utc).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 23, 17, 10, 553, DateTimeKind.Utc).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 23, 17, 10, 553, DateTimeKind.Utc).AddTicks(1529));

            migrationBuilder.UpdateData(
                table: "PizzaSize",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 23, 17, 10, 553, DateTimeKind.Utc).AddTicks(1711));

            migrationBuilder.UpdateData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 23, 17, 10, 554, DateTimeKind.Utc).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 23, 17, 10, 554, DateTimeKind.Utc).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 23, 17, 10, 554, DateTimeKind.Utc).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 23, 17, 10, 554, DateTimeKind.Utc).AddTicks(7026));

            migrationBuilder.UpdateData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 23, 17, 10, 554, DateTimeKind.Utc).AddTicks(7027));

            migrationBuilder.UpdateData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 23, 17, 10, 554, DateTimeKind.Utc).AddTicks(7028));

            migrationBuilder.UpdateData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 23, 17, 10, 554, DateTimeKind.Utc).AddTicks(7029));

            migrationBuilder.UpdateData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 23, 17, 10, 554, DateTimeKind.Utc).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 23, 17, 10, 554, DateTimeKind.Utc).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 23, 17, 10, 554, DateTimeKind.Utc).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 23, 17, 10, 554, DateTimeKind.Utc).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "PizzaToppings",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 23, 17, 10, 554, DateTimeKind.Utc).AddTicks(7035));

            migrationBuilder.InsertData(
                table: "ToppingsPrice",
                columns: new[] { "Id", "Active", "CreatedAt", "CreatedBy", "CreatedByName", "Deleted", "Price", "ToppingType", "UpdatedAt", "UpdatedBy", "UpdatedByName" },
                values: new object[,]
                {
                    { 7, true, new DateTime(2022, 4, 12, 23, 17, 10, 556, DateTimeKind.Utc).AddTicks(6387), 1, null, false, 1, 1, null, 0, null },
                    { 6, true, new DateTime(2022, 4, 12, 23, 17, 10, 556, DateTimeKind.Utc).AddTicks(6386), 1, null, false, 3, 3, null, 0, null },
                    { 5, true, new DateTime(2022, 4, 12, 23, 17, 10, 556, DateTimeKind.Utc).AddTicks(6385), 1, null, false, 4, 4, null, 0, null },
                    { 4, true, new DateTime(2022, 4, 12, 23, 17, 10, 556, DateTimeKind.Utc).AddTicks(6384), 1, null, false, 2, 2, null, 0, null },
                    { 3, true, new DateTime(2022, 4, 12, 23, 17, 10, 556, DateTimeKind.Utc).AddTicks(6383), 1, null, false, 4, 6, null, 0, null },
                    { 2, true, new DateTime(2022, 4, 12, 23, 17, 10, 556, DateTimeKind.Utc).AddTicks(6374), 1, null, false, 5, 5, null, 0, null },
                    { 8, true, new DateTime(2022, 4, 12, 23, 17, 10, 556, DateTimeKind.Utc).AddTicks(6388), 1, null, false, 2, 0, null, 0, null },
                    { 1, true, new DateTime(2022, 4, 12, 23, 17, 10, 556, DateTimeKind.Utc).AddTicks(6221), 1, null, false, 10, 4, null, 0, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PizzaCrust_PizzaMasterMenuId",
                table: "PizzaCrust",
                column: "PizzaMasterMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_CrustPrice_PizzaCrustId",
                table: "CrustPrice",
                column: "PizzaCrustId");

            migrationBuilder.CreateIndex(
                name: "IX_PizzaPrice_PizzaId",
                table: "PizzaPrice",
                column: "PizzaId");

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaCrust_PizzaMasterMenu_PizzaMasterMenuId",
                table: "PizzaCrust",
                column: "PizzaMasterMenuId",
                principalTable: "PizzaMasterMenu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PizzaCrust_PizzaMasterMenu_PizzaMasterMenuId",
                table: "PizzaCrust");

            migrationBuilder.DropTable(
                name: "CrustPrice");

            migrationBuilder.DropTable(
                name: "PizzaPrice");

            migrationBuilder.DropTable(
                name: "ToppingsPrice");

            migrationBuilder.DropIndex(
                name: "IX_PizzaCrust_PizzaMasterMenuId",
                table: "PizzaCrust");

            migrationBuilder.DropColumn(
                name: "PizzaMasterMenuId",
                table: "PizzaCrust");

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
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 13, 45, 18, 810, DateTimeKind.Utc).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "PizzaMasterMenu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 13, 45, 18, 810, DateTimeKind.Utc).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "PizzaMasterMenu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 13, 45, 18, 810, DateTimeKind.Utc).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "PizzaMasterMenu",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 12, 13, 45, 18, 810, DateTimeKind.Utc).AddTicks(4334));

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

            migrationBuilder.CreateIndex(
                name: "IX_PizzaCrust_PizzaId",
                table: "PizzaCrust",
                column: "PizzaId");

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaCrust_Master",
                table: "PizzaCrust",
                column: "PizzaId",
                principalTable: "PizzaMasterMenu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
