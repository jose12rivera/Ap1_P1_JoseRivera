﻿// <auto-generated />
using System;
using Ap1_P1_JoseRivera.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ap1_P1_JoseRivera.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20240613042108_Articulospp")]
    partial class Articulospp
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.5");

            modelBuilder.Entity("Ap1_P1_JoseRivera.Models.Articulos", b =>
                {
                    b.Property<int>("ArticuloId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("Costo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("Ganancia")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("Precio")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ArticuloId");

                    b.ToTable("Articulos");
                });
#pragma warning restore 612, 618
        }
    }
}
