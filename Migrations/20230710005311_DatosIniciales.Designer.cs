﻿// <auto-generated />
using System;
using IntroEF_Avanzado.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace PracticeAPIRestFull.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230710005311_DatosIniciales")]
    partial class DatosIniciales
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GeneroPelicula", b =>
                {
                    b.Property<int>("GenerosId")
                        .HasColumnType("int");

                    b.Property<int>("PeliculasId")
                        .HasColumnType("int");

                    b.HasKey("GenerosId", "PeliculasId");

                    b.HasIndex("PeliculasId");

                    b.ToTable("GeneroPelicula");

                    b.HasData(
                        new
                        {
                            GenerosId = 5,
                            PeliculasId = 2
                        },
                        new
                        {
                            GenerosId = 5,
                            PeliculasId = 3
                        },
                        new
                        {
                            GenerosId = 6,
                            PeliculasId = 4
                        });
                });

            modelBuilder.Entity("IntroEF_Avanzado.Models.Entidades.PeliculaActor", b =>
                {
                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("PeliculaId")
                        .HasColumnType("int");

                    b.Property<int>("Orden")
                        .HasColumnType("int");

                    b.Property<string>("Personaje")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ActorId", "PeliculaId");

                    b.HasIndex("PeliculaId");

                    b.ToTable("PeliculaActores");

                    b.HasData(
                        new
                        {
                            ActorId = 2,
                            PeliculaId = 3,
                            Orden = 1,
                            Personaje = "Nick Fury"
                        },
                        new
                        {
                            ActorId = 2,
                            PeliculaId = 2,
                            Orden = 2,
                            Personaje = "Nick Fury"
                        },
                        new
                        {
                            ActorId = 3,
                            PeliculaId = 2,
                            Orden = 1,
                            Personaje = "Iron Man"
                        });
                });

            modelBuilder.Entity("PracticeAPIRestFull.Models.Entidades.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("date");

                    b.Property<decimal>("Fortuna")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Actores");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            FechaNacimiento = new DateTime(1948, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fortuna = 15000m,
                            Nombre = "Samuel L. Jackson"
                        },
                        new
                        {
                            Id = 3,
                            FechaNacimiento = new DateTime(1965, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fortuna = 18000m,
                            Nombre = "Robert Downey Jr."
                        });
                });

            modelBuilder.Entity("PracticeAPIRestFull.Models.Entidades.Comentario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Contenido")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("PeliculaId")
                        .HasColumnType("int");

                    b.Property<bool>("Recomendar")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("PeliculaId");

                    b.ToTable("Comentarios");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Contenido = "Muy buena!!!",
                            PeliculaId = 2,
                            Recomendar = true
                        },
                        new
                        {
                            Id = 3,
                            Contenido = "Dura dura",
                            PeliculaId = 2,
                            Recomendar = true
                        },
                        new
                        {
                            Id = 4,
                            Contenido = "no debieron hacer eso...",
                            PeliculaId = 3,
                            Recomendar = false
                        });
                });

            modelBuilder.Entity("PracticeAPIRestFull.Models.Entidades.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Generos");

                    b.HasData(
                        new
                        {
                            Id = 5,
                            Nombre = "Ciencia Ficcion"
                        },
                        new
                        {
                            Id = 6,
                            Nombre = "Animacion"
                        });
                });

            modelBuilder.Entity("PracticeAPIRestFull.Models.Entidades.Pelicula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("FechaEstreno")
                        .HasColumnType("date");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("enCines")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Peliculas");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            FechaEstreno = new DateTime(2019, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Titulo = "Avengers Endgame",
                            enCines = false
                        },
                        new
                        {
                            Id = 3,
                            FechaEstreno = new DateTime(2021, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Titulo = "Spider-Man: No Way Home",
                            enCines = false
                        },
                        new
                        {
                            Id = 4,
                            FechaEstreno = new DateTime(2022, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Titulo = "Spider-Man: Across the Spider-Verse (Part One)",
                            enCines = false
                        });
                });

            modelBuilder.Entity("GeneroPelicula", b =>
                {
                    b.HasOne("PracticeAPIRestFull.Models.Entidades.Genero", null)
                        .WithMany()
                        .HasForeignKey("GenerosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PracticeAPIRestFull.Models.Entidades.Pelicula", null)
                        .WithMany()
                        .HasForeignKey("PeliculasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IntroEF_Avanzado.Models.Entidades.PeliculaActor", b =>
                {
                    b.HasOne("PracticeAPIRestFull.Models.Entidades.Actor", "Actor")
                        .WithMany("PeliculaActores")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PracticeAPIRestFull.Models.Entidades.Pelicula", "Pelicula")
                        .WithMany("PeliculaActores")
                        .HasForeignKey("PeliculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Pelicula");
                });

            modelBuilder.Entity("PracticeAPIRestFull.Models.Entidades.Comentario", b =>
                {
                    b.HasOne("PracticeAPIRestFull.Models.Entidades.Pelicula", "Pelicula")
                        .WithMany("Comentarios")
                        .HasForeignKey("PeliculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pelicula");
                });

            modelBuilder.Entity("PracticeAPIRestFull.Models.Entidades.Actor", b =>
                {
                    b.Navigation("PeliculaActores");
                });

            modelBuilder.Entity("PracticeAPIRestFull.Models.Entidades.Pelicula", b =>
                {
                    b.Navigation("Comentarios");

                    b.Navigation("PeliculaActores");
                });
#pragma warning restore 612, 618
        }
    }
}
