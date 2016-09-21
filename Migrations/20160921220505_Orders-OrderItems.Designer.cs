using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebStoreInventory.Models;

namespace WebStoreInventory.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20160921220505_Orders-OrderItems")]
    partial class OrdersOrderItems
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebStoreInventory.Models.ApplicationOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("WebStoreInventory.Models.ApplicationOrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ApplicationOrderId");

                    b.Property<int?>("ProductIdId");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationOrderId");

                    b.HasIndex("ProductIdId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("WebStoreInventory.Models.ApplicationProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("InitialQuantity");

                    b.Property<string>("Name");

                    b.Property<int>("Price");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("WebStoreInventory.Models.ApplicationProductItem", b =>
                {
                    b.Property<bool>("Sold");

                    b.Property<int?>("ApplicationOrderItemId");

                    b.Property<int?>("ProductId");

                    b.HasKey("Sold");

                    b.HasIndex("ApplicationOrderItemId");

                    b.HasIndex("ProductId");

                    b.ToTable("Inventory");
                });

            modelBuilder.Entity("WebStoreInventory.Models.ApplicationOrderItem", b =>
                {
                    b.HasOne("WebStoreInventory.Models.ApplicationOrder")
                        .WithMany("OrderItems")
                        .HasForeignKey("ApplicationOrderId");

                    b.HasOne("WebStoreInventory.Models.ApplicationProduct", "ProductId")
                        .WithMany()
                        .HasForeignKey("ProductIdId");
                });

            modelBuilder.Entity("WebStoreInventory.Models.ApplicationProductItem", b =>
                {
                    b.HasOne("WebStoreInventory.Models.ApplicationOrderItem")
                        .WithMany("ProductItems")
                        .HasForeignKey("ApplicationOrderItemId");

                    b.HasOne("WebStoreInventory.Models.ApplicationProduct", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });
        }
    }
}
