using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebStoreInventory.Migrations
{
    public partial class OrdersOrderItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ApplicationOrderId = table.Column<int>(nullable: true),
                    ProductIdId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_ApplicationOrderId",
                        column: x => x.ApplicationOrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductIdId",
                        column: x => x.ProductIdId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.AddColumn<int>(
                name: "ApplicationOrderItemId",
                table: "Inventory",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_ApplicationOrderItemId",
                table: "Inventory",
                column: "ApplicationOrderItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ApplicationOrderId",
                table: "OrderItems",
                column: "ApplicationOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductIdId",
                table: "OrderItems",
                column: "ProductIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_OrderItems_ApplicationOrderItemId",
                table: "Inventory",
                column: "ApplicationOrderItemId",
                principalTable: "OrderItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_OrderItems_ApplicationOrderItemId",
                table: "Inventory");

            migrationBuilder.DropIndex(
                name: "IX_Inventory_ApplicationOrderItemId",
                table: "Inventory");

            migrationBuilder.DropColumn(
                name: "ApplicationOrderItemId",
                table: "Inventory");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
