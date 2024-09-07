﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rating.Data;

#nullable disable

namespace Rating.Data.Migrations
{
    [DbContext(typeof(RatingDbContext))]
    partial class RatingDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Rating.Domain.Entties.AverageRating", b =>
                {
                    b.Property<int>("AvgRatingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AvgRatingId"));

                    b.Property<double>("AvgRating")
                        .HasColumnType("float");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("TotalReview")
                        .HasColumnType("int");

                    b.HasKey("AvgRatingId");

                    b.ToTable("AverageRating");

                    b.HasData(
                        new
                        {
                            AvgRatingId = 1,
                            AvgRating = 4.5,
                            BookId = 1001,
                            TotalReview = 2
                        },
                        new
                        {
                            AvgRatingId = 2,
                            AvgRating = 5.0,
                            BookId = 1002,
                            TotalReview = 1
                        });
                });

            modelBuilder.Entity("Rating.Domain.Entties.Reviews", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewId"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Review")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ReviewId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            ReviewId = 1,
                            BookId = 1001,
                            RatedDate = new DateTime(2024, 8, 28, 16, 52, 38, 83, DateTimeKind.Local).AddTicks(8824),
                            Rating = 5,
                            Review = "Great book on C# programming.",
                            UserId = 2001
                        },
                        new
                        {
                            ReviewId = 2,
                            BookId = 1001,
                            RatedDate = new DateTime(2024, 8, 30, 16, 52, 38, 83, DateTimeKind.Local).AddTicks(8845),
                            Rating = 4,
                            Review = "Informative but a bit lengthy.",
                            UserId = 2002
                        },
                        new
                        {
                            ReviewId = 3,
                            BookId = 1002,
                            RatedDate = new DateTime(2024, 9, 2, 16, 52, 38, 83, DateTimeKind.Local).AddTicks(8847),
                            Rating = 5,
                            Review = "Excellent introduction to algorithms.",
                            UserId = 2003
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
