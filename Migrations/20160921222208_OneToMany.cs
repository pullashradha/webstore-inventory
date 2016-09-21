using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebStoreInventory.Migrations
{
    public partial class OneToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_ApplicationOrderId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_OrderItems_ApplicationOrderItemId",
                table: "Inventory");

            migrationBuilder.DropIndex(
                name: "IX_Inventory_ApplicationOrderItemId",
                table: "Inventory");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_ApplicationOrderId",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "ApplicationOrderItemId",
                table: "Inventory");

            migrationBuilder.DropColumn(
                name: "ApplicationOrderId",
                table: "OrderItems");

            migrationBuilder.AddColumn<int>(
                name: "OrderItemId",
                table: "Inventory",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "OrderItems",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_OrderItemId",
                table: "Inventory",
                column: "OrderItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_OrderItems_OrderItemId",
                table: "Inventory",
                column: "OrderItemId",
                principalTable: "OrderItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_OrderItems_OrderItemId",
                table: "Inventory");

            migrationBuilder.DropIndex(
                name: "IX_Inventory_OrderItemId",
                table: "Inventory");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "OrderItemId",
                table: "Inventory");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "OrderItems");

            migrationBuilder.AddColumn<int>(
                name: "ApplicationOrderItemId",
                table: "Inventory",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ApplicationOrderId",
                table: "OrderItems",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_ApplicationOrderItemId",
                table: "Inventory",
                column: "ApplicationOrderItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ApplicationOrderId",
                table: "OrderItems",
                column: "ApplicationOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_ApplicationOrderId",
                table: "OrderItems",
                column: "ApplicationOrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_OrderItems_ApplicationOrderItemId",
                table: "Inventory",
                column: "ApplicationOrderItemId",
                principalTable: "OrderItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
