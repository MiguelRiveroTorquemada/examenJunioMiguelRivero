﻿// <auto-generated />
using Libros.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace examenJunioMiguelRivero.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220530190503_nombre")]
    partial class nombre
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LibroItem.LibroItems", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("actores")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("autor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("año")
                        .HasColumnType("int");

                    b.Property<string>("categoria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("director")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("duracion")
                        .HasColumnType("int");

                    b.Property<int>("likes")
                        .HasColumnType("int");

                    b.Property<int>("puntuacion")
                        .HasColumnType("int");

                    b.Property<string>("sinopsis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("subgenero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("LibroItem");
                });
#pragma warning restore 612, 618
        }
    }
}
