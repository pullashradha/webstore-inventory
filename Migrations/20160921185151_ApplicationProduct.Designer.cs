using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebStoreInventory.Models;

namespace WebStoreInventory.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20160921185151_ApplicationProduct")]
    partial class ApplicationProduct
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<int?>("ProductId");

                    b.HasKey("Sold");

                    b.HasIndex("ProductId");

                    b.ToTable("Inventory");
                });

            modelBuilder.Entity("WebStoreInventory.Models.ApplicationProductItem", b =>
                {
                    b.HasOne("WebStoreInventory.Models.ApplicationProduct", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });
        }
    }
}
