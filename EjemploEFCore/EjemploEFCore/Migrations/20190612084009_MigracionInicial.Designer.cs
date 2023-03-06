﻿// <auto-generated />
using System;
using EjemploEFCore.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EjemploEFCore.Migrations
{
    [DbContext(typeof(ContextoDB))]
    [Migration("20190612084009_MigracionInicial")]
    partial class MigracionInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EjemploEFCore.Models.Cancion", b =>
                {
                    b.Property<int>("CancionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion");

                    b.Property<TimeSpan>("Duracion");

                    b.Property<string>("Titulo");

                    b.HasKey("CancionId");

                    b.ToTable("Canciones");
                });
#pragma warning restore 612, 618
        }
    }
}