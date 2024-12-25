﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using crud.DataAccess;

#nullable disable

namespace crud.DataAccess.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    [Migration("20241225192930_SeedData")]
    partial class SeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("crud.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Description 1",
                            Name = "Product 1-db",
                            Status = 0,
                            price = 10.0,
                            quantity = 10
                        },
                        new
                        {
                            Id = 2,
                            Description = "Description 2",
                            Name = "Product 2-db",
                            Status = 1,
                            price = 20.0,
                            quantity = 20
                        },
                        new
                        {
                            Id = 3,
                            Description = "Description 3",
                            Name = "Product 3-db",
                            Status = 2,
                            price = 30.0,
                            quantity = 30
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
