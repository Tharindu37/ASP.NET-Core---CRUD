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
    [Migration("20241225195519_UserAndData")]
    partial class UserAndData
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

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Description 1",
                            Name = "Product 1-db",
                            Price = 10.0,
                            Quantity = 10,
                            Status = 0,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "Description 2",
                            Name = "Product 2-db",
                            Price = 20.0,
                            Quantity = 20,
                            Status = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            Description = "Description 3",
                            Name = "Product 3-db",
                            Price = 30.0,
                            Quantity = 30,
                            Status = 2,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("crud.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "User 1-db"
                        },
                        new
                        {
                            Id = 2,
                            Name = "User 2-db"
                        },
                        new
                        {
                            Id = 3,
                            Name = "User 3-db"
                        });
                });

            modelBuilder.Entity("crud.Models.Product", b =>
                {
                    b.HasOne("crud.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}