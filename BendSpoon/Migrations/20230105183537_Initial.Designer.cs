// <auto-generated />
using System;
using BendSpoon.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BendSpoon.Migrations
{
    [DbContext(typeof(BendSpoonContext))]
    [Migration("20230105183537_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BendSpoon.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("BendSpoon.Models.EmployeeRestaurant", b =>
                {
                    b.Property<int>("EmployeeRestaurantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeRestaurantId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("EmployeeRestaurants");
                });

            modelBuilder.Entity("BendSpoon.Models.Restaurant", b =>
                {
                    b.Property<int>("RestaurantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("RestName")
                        .HasColumnType("longtext");

                    b.Property<string>("Type")
                        .HasColumnType("longtext");

                    b.HasKey("RestaurantId");

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("EmployeeRestaurant", b =>
                {
                    b.Property<int>("EmployeesEmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("RestaurantsRestaurantId")
                        .HasColumnType("int");

                    b.HasKey("EmployeesEmployeeId", "RestaurantsRestaurantId");

                    b.HasIndex("RestaurantsRestaurantId");

                    b.ToTable("EmployeeRestaurant");
                });

            modelBuilder.Entity("BendSpoon.Models.EmployeeRestaurant", b =>
                {
                    b.HasOne("BendSpoon.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BendSpoon.Models.Restaurant", "Restaurant")
                        .WithMany()
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("EmployeeRestaurant", b =>
                {
                    b.HasOne("BendSpoon.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BendSpoon.Models.Restaurant", null)
                        .WithMany()
                        .HasForeignKey("RestaurantsRestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
