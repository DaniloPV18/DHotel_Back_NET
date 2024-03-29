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
    [Migration("20240106182051_ServicioOfrecido_tabla_actualizada")]
    partial class ServicioOfrecidotablaactualizada
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

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdAdminRegistro")
                        .HasColumnType("int");

                    b.Property<int>("PagoId")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorPagado")
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

                    b.Property<int>("AdministradorId")
                        .HasColumnType("int");

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("EstadoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("date");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int>("GeneroId")
                        .HasColumnType("int");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Pwd")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("RolId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UltimaActividad")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Administradores");
                });

            modelBuilder.Entity("DHotel_Back.Models.Habitacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AdministradorId")
                        .HasColumnType("int");

                    b.Property<int>("EstadoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Foto")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<decimal>("Precio")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.Property<int>("TipoHabitacionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdministradorId");

                    b.ToTable("Habitaciones");
                });

            modelBuilder.Entity("DHotel_Back.Models.HabitacionServicioOfrecido", b =>
                {
                    b.Property<int>("HabitacionId")
                        .HasColumnType("int");

                    b.Property<int>("ServicioOfrecidoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.HasKey("HabitacionId", "ServicioOfrecidoId");

                    b.HasIndex("ServicioOfrecidoId");

                    b.ToTable("HabitacionServicioOfrecido");
                });

            modelBuilder.Entity("DHotel_Back.Models.Huesped", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AdministradorId")
                        .HasColumnType("int");

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int>("GeneroId")
                        .HasColumnType("int");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("AdministradorId");

                    b.ToTable("Huespedes");
                });

            modelBuilder.Entity("DHotel_Back.Models.Pago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AdministradorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("date");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("date");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int>("HabitacionId")
                        .HasColumnType("int");

                    b.Property<int>("HuespedId")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoPago")
                        .HasColumnType("int");

                    b.Property<string>("ServiciosHabitacion")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<decimal>("ValorAPagar")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.Property<decimal>("ValorPagado")
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
                });

            modelBuilder.Entity("DHotel_Back.Models.AbonoReserva", b =>
                {
                    b.HasOne("DHotel_Back.Models.Pago", "Pago")
                        .WithMany("AbonosReservas")
                        .HasForeignKey("PagoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pago");
                });

            modelBuilder.Entity("DHotel_Back.Models.Habitacion", b =>
                {
                    b.HasOne("DHotel_Back.Models.Administrador", "Administrador")
                        .WithMany("Habitaciones")
                        .HasForeignKey("AdministradorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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
                        .HasForeignKey("AdministradorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DHotel_Back.Models.Huesped", "Huesped")
                        .WithMany("Pagos")
                        .HasForeignKey("HuespedId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

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
