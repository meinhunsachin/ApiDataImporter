﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiDataImporter.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230929204909_InitialCreate5")]
    partial class InitialCreate5
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("ApiDataImporter.Models.Article", b =>
                {
                    b.Property<string>("Journal")
                        .HasColumnType("TEXT");

                    b.HasKey("Journal");

                    b.ToTable("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}
