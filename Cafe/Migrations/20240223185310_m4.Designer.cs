﻿// <auto-generated />
using System;
using Cafe.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Cafe.Migrations
{
    [DbContext(typeof(CafeDbContext))]
    [Migration("20240223185310_m4")]
    partial class m4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("Cafe.Models.ClientTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ClientTables");
                });

            modelBuilder.Entity("Cafe.Models.Currency", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Code");

                    b.HasIndex("Name");

                    b.ToTable("Currencies");
                });

            modelBuilder.Entity("Cafe.Models.Nomenclature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Nomenclatures");
                });

            modelBuilder.Entity("Cafe.Models.Order", b =>
                {
                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<double>("Bill")
                        .HasColumnType("REAL");

                    b.Property<int>("ClientTableId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WaiterId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Date");

                    b.HasIndex("ClientTableId");

                    b.HasIndex("WaiterId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Cafe.Models.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Count")
                        .HasColumnType("REAL");

                    b.Property<int>("NomenclatureId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<double>("Sum")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("NomenclatureId");

                    b.HasIndex("OrderDate");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Cafe.Models.Waiter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Waiters");
                });

            modelBuilder.Entity("Cafe.Models.Order", b =>
                {
                    b.HasOne("Cafe.Models.ClientTable", "ClientTable")
                        .WithMany("Orders")
                        .HasForeignKey("ClientTableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cafe.Models.Waiter", "Waiter")
                        .WithMany("Orders")
                        .HasForeignKey("WaiterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClientTable");

                    b.Navigation("Waiter");
                });

            modelBuilder.Entity("Cafe.Models.OrderDetail", b =>
                {
                    b.HasOne("Cafe.Models.Nomenclature", "Nomenclature")
                        .WithMany()
                        .HasForeignKey("NomenclatureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cafe.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderDate")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Nomenclature");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Cafe.Models.ClientTable", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Cafe.Models.Waiter", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
