using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shops.Migrations
{
    public partial class sec : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(maxLength: 20, nullable: false),
                    surname = table.Column<string>(maxLength: 20, nullable: false),
                    address = table.Column<string>(maxLength: 35, nullable: false),
                    phone = table.Column<string>(maxLength: 11, nullable: false),
                    email = table.Column<string>(maxLength: 25, nullable: false),
                    dateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    orderID = table.Column<int>(nullable: false),
                    carID = table.Column<int>(nullable: false),
                    price = table.Column<uint>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.id);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Car_carID",
                        column: x => x.carID,
                        principalTable: "Car",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Order_orderID",
                        column: x => x.orderID,
                        principalTable: "Order",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_carID",
                table: "OrderDetail",
                column: "carID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_orderID",
                table: "OrderDetail",
                column: "orderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "Order");
        }
    }
}
