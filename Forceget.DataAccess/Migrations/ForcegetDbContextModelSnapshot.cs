﻿// <auto-generated />
using System;
using Forceget.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Forceget.DataAccess.Migrations
{
    [DbContext(typeof(ForcegetDbContext))]
    partial class ForcegetDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Forceget.Core.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("longblob");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("longblob");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Forceget.Entities.Concrete.City", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CountryId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Forceget.Entities.Concrete.Country", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Forceget.Entities.Concrete.Currency", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Currencies");
                });

            modelBuilder.Entity("Forceget.Entities.Concrete.Incoterm", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Incoterms");
                });

            modelBuilder.Entity("Forceget.Entities.Concrete.Mode", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Modes");
                });

            modelBuilder.Entity("Forceget.Entities.Concrete.MovementType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("MovementTypes");
                });

            modelBuilder.Entity("Forceget.Entities.Concrete.Offer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CityId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("CountryId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("CurrencyId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("IncotermId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("ModeId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("MovementTypeId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("PackageTypeId")
                        .HasColumnType("char(36)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("Unit1Id")
                        .HasColumnType("char(36)");

                    b.Property<int>("Unit1Value")
                        .HasColumnType("int");

                    b.Property<Guid>("Unit2Id")
                        .HasColumnType("char(36)");

                    b.Property<int>("Unit2Value")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("IncotermId");

                    b.HasIndex("ModeId");

                    b.HasIndex("MovementTypeId");

                    b.HasIndex("PackageTypeId");

                    b.HasIndex("Unit1Id");

                    b.HasIndex("Unit2Id");

                    b.ToTable("Offers");
                });

            modelBuilder.Entity("Forceget.Entities.Concrete.PackageType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("PackageTypes");
                });

            modelBuilder.Entity("Forceget.Entities.Concrete.Unit1", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Unit1s");
                });

            modelBuilder.Entity("Forceget.Entities.Concrete.Unit2", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Unit2s");
                });

            modelBuilder.Entity("Forceget.Entities.Concrete.City", b =>
                {
                    b.HasOne("Forceget.Entities.Concrete.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Forceget.Entities.Concrete.Offer", b =>
                {
                    b.HasOne("Forceget.Entities.Concrete.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Forceget.Entities.Concrete.Country", null)
                        .WithMany("Offers")
                        .HasForeignKey("CountryId");

                    b.HasOne("Forceget.Entities.Concrete.Currency", "Currency")
                        .WithMany("Offer")
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Forceget.Entities.Concrete.Incoterm", "Incoterm")
                        .WithMany("Offer")
                        .HasForeignKey("IncotermId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Forceget.Entities.Concrete.Mode", "Mode")
                        .WithMany("Offer")
                        .HasForeignKey("ModeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Forceget.Entities.Concrete.MovementType", "MovementType")
                        .WithMany("Offer")
                        .HasForeignKey("MovementTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Forceget.Entities.Concrete.PackageType", "PackageType")
                        .WithMany("Offer")
                        .HasForeignKey("PackageTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Forceget.Entities.Concrete.Unit1", "Unit1")
                        .WithMany("Offer")
                        .HasForeignKey("Unit1Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Forceget.Entities.Concrete.Unit2", "Unit2")
                        .WithMany("Offer")
                        .HasForeignKey("Unit2Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("Currency");

                    b.Navigation("Incoterm");

                    b.Navigation("Mode");

                    b.Navigation("MovementType");

                    b.Navigation("PackageType");

                    b.Navigation("Unit1");

                    b.Navigation("Unit2");
                });

            modelBuilder.Entity("Forceget.Entities.Concrete.Country", b =>
                {
                    b.Navigation("Cities");

                    b.Navigation("Offers");
                });

            modelBuilder.Entity("Forceget.Entities.Concrete.Currency", b =>
                {
                    b.Navigation("Offer");
                });

            modelBuilder.Entity("Forceget.Entities.Concrete.Incoterm", b =>
                {
                    b.Navigation("Offer");
                });

            modelBuilder.Entity("Forceget.Entities.Concrete.Mode", b =>
                {
                    b.Navigation("Offer");
                });

            modelBuilder.Entity("Forceget.Entities.Concrete.MovementType", b =>
                {
                    b.Navigation("Offer");
                });

            modelBuilder.Entity("Forceget.Entities.Concrete.PackageType", b =>
                {
                    b.Navigation("Offer");
                });

            modelBuilder.Entity("Forceget.Entities.Concrete.Unit1", b =>
                {
                    b.Navigation("Offer");
                });

            modelBuilder.Entity("Forceget.Entities.Concrete.Unit2", b =>
                {
                    b.Navigation("Offer");
                });
#pragma warning restore 612, 618
        }
    }
}
