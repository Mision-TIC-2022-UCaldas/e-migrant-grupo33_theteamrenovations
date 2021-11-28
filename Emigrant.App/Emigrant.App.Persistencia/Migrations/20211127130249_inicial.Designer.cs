﻿// <auto-generated />
using System;
using Emigrant.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Emigrant.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20211127130249_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Emigrant.App.Dominio.Entidad", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ciudad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correoEntidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("nit")
                        .HasColumnType("int");

                    b.Property<string>("razon_Social")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("sector")
                        .HasColumnType("int");

                    b.Property<string>("telefonoEntidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tipoServicio")
                        .HasColumnType("int");

                    b.Property<string>("web")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Entidades");
                });

            modelBuilder.Entity("Emigrant.App.Dominio.Migrante", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fecha_nacimiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("identificacion")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pais")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sit_laboral")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tipo_documento")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Migrantes");
                });

            modelBuilder.Entity("Emigrant.App.Dominio.grupoMigrante", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("id_migrante")
                        .HasColumnType("int");

                    b.Property<int>("identificacion")
                        .HasColumnType("int");

                    b.Property<string>("parentesco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Grupos");
                });

            modelBuilder.Entity("Emigrant.App.Dominio.necesidades", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("detalles")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id_servicio")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Necesidades");
                });

            modelBuilder.Entity("Emigrant.App.Dominio.servicios", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("fechaFinal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fechaIni")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombreServicio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numCupos")
                        .HasColumnType("int");

                    b.Property<int>("prioridad")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Servicios");
                });
#pragma warning restore 612, 618
        }
    }
}