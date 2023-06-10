﻿// <auto-generated />
using System;
using ECommerce.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ECommerce.EntityFramework.Migrations
{
    [DbContext(typeof(DefaultDbContext))]
    partial class DefaultDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ECommerce.Data.Models.Authors", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("CreatedByAuthorsId")
                        .HasColumnType("char(36)");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("UpdatedAuthorsId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByAuthorsId");

                    b.HasIndex("UpdatedAuthorsId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("ECommerce.Data.Models.Authors", b =>
                {
                    b.HasOne("ECommerce.Data.Models.Authors", "CreatedByAuthors")
                        .WithMany()
                        .HasForeignKey("CreatedByAuthorsId");

                    b.HasOne("ECommerce.Data.Models.Authors", "UpdatedByAuthors")
                        .WithMany()
                        .HasForeignKey("UpdatedAuthorsId");

                    b.Navigation("CreatedByAuthors");

                    b.Navigation("UpdatedByAuthors");
                });
#pragma warning restore 612, 618
        }
    }
}