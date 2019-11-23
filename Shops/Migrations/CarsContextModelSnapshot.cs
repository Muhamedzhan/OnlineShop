﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shops.Data;

namespace Shops.Migrations
{
    [DbContext(typeof(CarsContext))]
    partial class CarsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("Shops.Data.Models.Car", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("available")
                        .HasColumnType("INTEGER");

                    b.Property<int>("categoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("img")
                        .HasColumnType("TEXT");

                    b.Property<bool>("isFavourite")
                        .HasColumnType("INTEGER");

                    b.Property<string>("longDesc")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<ushort>("price")
                        .HasColumnType("INTEGER");

                    b.Property<string>("shortDesc")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("categoryId");

                    b.ToTable("Car");
                });

            modelBuilder.Entity("Shops.Data.Models.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("categoryName")
                        .HasColumnType("TEXT");

                    b.Property<string>("desc")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Shops.Data.Models.ShopCartItem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ShopCartId")
                        .HasColumnType("TEXT");

                    b.Property<int?>("carid")
                        .HasColumnType("INTEGER");

                    b.Property<int>("price")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("carid");

                    b.ToTable("ShopCartItem");
                });

            modelBuilder.Entity("Shops.Data.Models.Car", b =>
                {
                    b.HasOne("Shops.Data.Models.Category", "Category")
                        .WithMany("cars")
                        .HasForeignKey("categoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Shops.Data.Models.ShopCartItem", b =>
                {
                    b.HasOne("Shops.Data.Models.Car", "car")
                        .WithMany()
                        .HasForeignKey("carid");
                });
#pragma warning restore 612, 618
        }
    }
}
