﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiDataImporter.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231001055947_InitialCreate012da5000000")]
    partial class InitialCreate012da5000000
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("ApiDataImporter.Models.Abstract", b =>
                {
                    b.Property<int>("AbstractId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ArticleId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.HasKey("AbstractId");

                    b.HasIndex("ArticleId");

                    b.ToTable("Abstracts");
                });

            modelBuilder.Entity("ApiDataImporter.Models.Article", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ArticleType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Eissn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Journal")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("PublicationDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Score")
                        .HasColumnType("REAL");

                    b.Property<string>("TitleDisplay")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("ApiDataImporter.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ArticleId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("AuthorId");

                    b.HasIndex("ArticleId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("ApiDataImporter.Models.Abstract", b =>
                {
                    b.HasOne("ApiDataImporter.Models.Article", null)
                        .WithMany("Abstract")
                        .HasForeignKey("ArticleId");
                });

            modelBuilder.Entity("ApiDataImporter.Models.Author", b =>
                {
                    b.HasOne("ApiDataImporter.Models.Article", null)
                        .WithMany("AuthorDisplay")
                        .HasForeignKey("ArticleId");
                });

            modelBuilder.Entity("ApiDataImporter.Models.Article", b =>
                {
                    b.Navigation("Abstract");

                    b.Navigation("AuthorDisplay");
                });
#pragma warning restore 612, 618
        }
    }
}
