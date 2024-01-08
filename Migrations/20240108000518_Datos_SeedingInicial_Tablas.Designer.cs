﻿// <auto-generated />
using System;
using DHotel_Back.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DHotelBack.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240108000518_Datos_SeedingInicial_Tablas")]
    partial class DatosSeedingInicialTablas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DHotel_Back.Models.AbonoReserva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdAdminRegistro")
                        .HasColumnType("int");

                    b.Property<int?>("PagoId")
                        .HasColumnType("int");

                    b.Property<decimal?>("ValorPagado")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("Id");

                    b.HasIndex("PagoId");

                    b.ToTable("AbonosReservas");
                });

            modelBuilder.Entity("DHotel_Back.Models.Administrador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AdministradorId")
                        .HasColumnType("int");

                    b.Property<string>("Apellidos")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Cedula")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Celular")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Email")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int?>("EstadoId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaNacimiento")
                        .HasColumnType("date");

                    b.Property<DateTime?>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int?>("GeneroId")
                        .HasColumnType("int");

                    b.Property<string>("Nombres")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Pwd")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int?>("RolId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UltimaActividad")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Administradores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Apellidos = "Zambrano",
                            Cedula = "0931600548",
                            Celular = "0962723152",
                            Email = "micaela@gmail.com",
                            EstadoId = 1,
                            FechaRegistro = new DateTime(2024, 1, 7, 19, 5, 18, 7, DateTimeKind.Local).AddTicks(7605),
                            GeneroId = 2,
                            Nombres = "Micaela",
                            Pwd = "0931600548",
                            RolId = 1
                        },
                        new
                        {
                            Id = 2,
                            Apellidos = "Lasso",
                            Cedula = "0931600549",
                            Celular = "0962723152",
                            Email = "sonia@gmail.com",
                            EstadoId = 1,
                            FechaRegistro = new DateTime(2024, 1, 7, 19, 5, 18, 7, DateTimeKind.Local).AddTicks(7665),
                            GeneroId = 2,
                            Nombres = "Sonia",
                            Pwd = "0931600549",
                            RolId = 2
                        },
                        new
                        {
                            Id = 3,
                            Apellidos = "Marion",
                            Cedula = "0931600550",
                            Celular = "0962723152",
                            Email = "milo@gmail.com",
                            EstadoId = 1,
                            FechaRegistro = new DateTime(2024, 1, 7, 19, 5, 18, 7, DateTimeKind.Local).AddTicks(7667),
                            GeneroId = 1,
                            Nombres = "Milo",
                            Pwd = "0931600550",
                            RolId = 1
                        });
                });

            modelBuilder.Entity("DHotel_Back.Models.Habitacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AdministradorId")
                        .HasColumnType("int");

                    b.Property<int?>("EstadoId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Foto")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int?>("Numero")
                        .HasColumnType("int");

                    b.Property<decimal?>("Precio")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.Property<int?>("TipoHabitacionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdministradorId");

                    b.ToTable("Habitaciones");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EstadoId = 1,
                            FechaRegistro = new DateTime(2024, 1, 7, 19, 5, 18, 7, DateTimeKind.Local).AddTicks(7795),
                            Numero = 400
                        },
                        new
                        {
                            Id = 2,
                            EstadoId = 1,
                            FechaRegistro = new DateTime(2024, 1, 7, 19, 5, 18, 7, DateTimeKind.Local).AddTicks(7796),
                            Numero = 401
                        },
                        new
                        {
                            Id = 3,
                            EstadoId = 1,
                            FechaRegistro = new DateTime(2024, 1, 7, 19, 5, 18, 7, DateTimeKind.Local).AddTicks(7797),
                            Numero = 402
                        });
                });

            modelBuilder.Entity("DHotel_Back.Models.HabitacionServicioOfrecido", b =>
                {
                    b.Property<int?>("HabitacionId")
                        .HasColumnType("int");

                    b.Property<int?>("ServicioOfrecidoId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.HasKey("HabitacionId", "ServicioOfrecidoId");

                    b.HasIndex("ServicioOfrecidoId");

                    b.ToTable("HabitacionServicioOfrecido");

                    b.HasData(
                        new
                        {
                            HabitacionId = 1,
                            ServicioOfrecidoId = 1,
                            FechaRegistro = new DateTime(2024, 1, 7, 19, 5, 18, 7, DateTimeKind.Local).AddTicks(7808)
                        },
                        new
                        {
                            HabitacionId = 1,
                            ServicioOfrecidoId = 2,
                            FechaRegistro = new DateTime(2024, 1, 7, 19, 5, 18, 7, DateTimeKind.Local).AddTicks(7809)
                        });
                });

            modelBuilder.Entity("DHotel_Back.Models.Huesped", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AdministradorId")
                        .HasColumnType("int");

                    b.Property<string>("Apellidos")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Cedula")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Celular")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Email")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int?>("GeneroId")
                        .HasColumnType("int");

                    b.Property<string>("Nombres")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("AdministradorId");

                    b.ToTable("Huespedes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Apellidos = "Karita",
                            Cedula = "0931600897",
                            Celular = "0962723152",
                            Email = "Keila@gmail.com",
                            FechaRegistro = new DateTime(2024, 1, 7, 19, 5, 18, 7, DateTimeKind.Local).AddTicks(7761),
                            GeneroId = 2,
                            Nombres = "Keila"
                        },
                        new
                        {
                            Id = 2,
                            Apellidos = "Alesso",
                            Cedula = "0931600898",
                            Celular = "0962723152",
                            Email = "Alejandro@gmail.com",
                            FechaRegistro = new DateTime(2024, 1, 7, 19, 5, 18, 7, DateTimeKind.Local).AddTicks(7763),
                            GeneroId = 1,
                            Nombres = "Alejandro"
                        },
                        new
                        {
                            Id = 3,
                            Apellidos = "Toala",
                            Cedula = "0931600899",
                            Celular = "0962723152",
                            Email = "Pepe@gmail.com",
                            FechaRegistro = new DateTime(2024, 1, 7, 19, 5, 18, 7, DateTimeKind.Local).AddTicks(7764),
                            GeneroId = 1,
                            Nombres = "Pepe"
                        });
                });

            modelBuilder.Entity("DHotel_Back.Models.Pago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AdministradorId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaFin")
                        .HasColumnType("date");

                    b.Property<DateTime?>("FechaInicio")
                        .HasColumnType("date");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HabitacionId")
                        .HasColumnType("int");

                    b.Property<int?>("HuespedId")
                        .HasColumnType("int");

                    b.Property<int?>("IdTipoPago")
                        .HasColumnType("int");

                    b.Property<string>("ServiciosHabitacion")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<decimal?>("ValorAPagar")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.Property<decimal?>("ValorPagado")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("Id");

                    b.HasIndex("AdministradorId");

                    b.HasIndex("HabitacionId");

                    b.HasIndex("HuespedId");

                    b.ToTable("Pagos");
                });

            modelBuilder.Entity("DHotel_Back.Models.ServicioOfrecido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AdministradorId")
                        .HasColumnType("int");

                    b.Property<string>("Codigo")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int?>("EstadoId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("AdministradorId");

                    b.ToTable("ServiciosOfrecidos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Codigo = "NET",
                            EstadoId = 1,
                            FechaRegistro = new DateTime(2024, 1, 7, 19, 5, 18, 7, DateTimeKind.Local).AddTicks(7780),
                            Nombre = "Internet"
                        },
                        new
                        {
                            Id = 2,
                            Codigo = "TV",
                            EstadoId = 1,
                            FechaRegistro = new DateTime(2024, 1, 7, 19, 5, 18, 7, DateTimeKind.Local).AddTicks(7781),
                            Nombre = "Television Cable"
                        },
                        new
                        {
                            Id = 3,
                            Codigo = "AIR",
                            EstadoId = 1,
                            FechaRegistro = new DateTime(2024, 1, 7, 19, 5, 18, 7, DateTimeKind.Local).AddTicks(7782),
                            Nombre = "Aire Acondicionado"
                        });
                });

            modelBuilder.Entity("DHotel_Back.Models.AbonoReserva", b =>
                {
                    b.HasOne("DHotel_Back.Models.Pago", "Pago")
                        .WithMany("AbonosReservas")
                        .HasForeignKey("PagoId");

                    b.Navigation("Pago");
                });

            modelBuilder.Entity("DHotel_Back.Models.Habitacion", b =>
                {
                    b.HasOne("DHotel_Back.Models.Administrador", "Administrador")
                        .WithMany("Habitaciones")
                        .HasForeignKey("AdministradorId");

                    b.Navigation("Administrador");
                });

            modelBuilder.Entity("DHotel_Back.Models.HabitacionServicioOfrecido", b =>
                {
                    b.HasOne("DHotel_Back.Models.Habitacion", "Habitacion")
                        .WithMany("HabitacionServicioOfrecido")
                        .HasForeignKey("HabitacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DHotel_Back.Models.ServicioOfrecido", "ServicioOfrecido")
                        .WithMany("HabitacionServicioOfrecido")
                        .HasForeignKey("ServicioOfrecidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Habitacion");

                    b.Navigation("ServicioOfrecido");
                });

            modelBuilder.Entity("DHotel_Back.Models.Huesped", b =>
                {
                    b.HasOne("DHotel_Back.Models.Administrador", "Administrador")
                        .WithMany()
                        .HasForeignKey("AdministradorId");

                    b.Navigation("Administrador");
                });

            modelBuilder.Entity("DHotel_Back.Models.Pago", b =>
                {
                    b.HasOne("DHotel_Back.Models.Administrador", null)
                        .WithMany("Pagos")
                        .HasForeignKey("AdministradorId");

                    b.HasOne("DHotel_Back.Models.Habitacion", "Habitacion")
                        .WithMany("Pagos")
                        .HasForeignKey("HabitacionId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DHotel_Back.Models.Huesped", "Huesped")
                        .WithMany("Pagos")
                        .HasForeignKey("HuespedId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Habitacion");

                    b.Navigation("Huesped");
                });

            modelBuilder.Entity("DHotel_Back.Models.ServicioOfrecido", b =>
                {
                    b.HasOne("DHotel_Back.Models.Administrador", "Administrador")
                        .WithMany("ServicioOfrecido")
                        .HasForeignKey("AdministradorId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Administrador");
                });

            modelBuilder.Entity("DHotel_Back.Models.Administrador", b =>
                {
                    b.Navigation("Habitaciones");

                    b.Navigation("Pagos");

                    b.Navigation("ServicioOfrecido");
                });

            modelBuilder.Entity("DHotel_Back.Models.Habitacion", b =>
                {
                    b.Navigation("HabitacionServicioOfrecido");

                    b.Navigation("Pagos");
                });

            modelBuilder.Entity("DHotel_Back.Models.Huesped", b =>
                {
                    b.Navigation("Pagos");
                });

            modelBuilder.Entity("DHotel_Back.Models.Pago", b =>
                {
                    b.Navigation("AbonosReservas");
                });

            modelBuilder.Entity("DHotel_Back.Models.ServicioOfrecido", b =>
                {
                    b.Navigation("HabitacionServicioOfrecido");
                });
#pragma warning restore 612, 618
        }
    }
}
