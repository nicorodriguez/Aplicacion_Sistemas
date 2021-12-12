﻿// <auto-generated />
using Aplicacion_Sistemas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Aplicacion_Sistemas.Migrations
{
    [DbContext(typeof(Proyecto_SistemasContext))]
    [Migration("20211212224504_Contrasenia")]
    partial class Contrasenia
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Aplicacion_Sistemas.Models.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad")
                        .HasColumnName("cantidad")
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnName("marca")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("nombre")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<decimal>("Precio")
                        .HasColumnName("precio")
                        .HasColumnType("decimal(6, 2)");

                    b.Property<int>("TipoProductoId")
                        .HasColumnName("tipo_producto_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TipoProductoId");

                    b.ToTable("Producto");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cantidad = 10,
                            Marca = "La Mejor",
                            Nombre = "Ventilador",
                            Precio = 10.500m,
                            TipoProductoId = 4
                        },
                        new
                        {
                            Id = 2,
                            Cantidad = 30,
                            Marca = "Kunington",
                            Nombre = "Gaseosa sabor Ginger Ale 1.5L",
                            Precio = 80m,
                            TipoProductoId = 3
                        },
                        new
                        {
                            Id = 3,
                            Cantidad = 90,
                            Marca = "Kunington",
                            Nombre = "Gaseosa sabor Cola 1.5L",
                            Precio = 85m,
                            TipoProductoId = 3
                        },
                        new
                        {
                            Id = 4,
                            Cantidad = 20,
                            Marca = "Excelente",
                            Nombre = "Papa blanca 1Kg",
                            Precio = 40m,
                            TipoProductoId = 2
                        });
                });

            modelBuilder.Entity("Aplicacion_Sistemas.Models.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("nombre")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Rol");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Empleado"
                        });
                });

            modelBuilder.Entity("Aplicacion_Sistemas.Models.TipoProducto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("nombre")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Tipo_Producto");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Carnes"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Verduras"
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Bebidas"
                        },
                        new
                        {
                            Id = 4,
                            Nombre = "Electrodomésticos"
                        },
                        new
                        {
                            Id = 5,
                            Nombre = "Golosinas"
                        },
                        new
                        {
                            Id = 6,
                            Nombre = "Envasados"
                        });
                });

            modelBuilder.Entity("Aplicacion_Sistemas.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnName("apellido")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Contrasena")
                        .IsRequired()
                        .HasColumnName("contrasena")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("nombre")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("NombreDeUsuario")
                        .IsRequired()
                        .HasColumnName("nombre_de_usuario")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("RolId")
                        .HasColumnName("rol_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RolId");

                    b.ToTable("Usuario");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Apellido = "Saltirana",
                            Contrasena = "123456",
                            Nombre = "Carla",
                            NombreDeUsuario = "carlasaltirana",
                            RolId = 1
                        },
                        new
                        {
                            Id = 2,
                            Apellido = "Perez",
                            Contrasena = "empleado",
                            Nombre = "Jorge",
                            NombreDeUsuario = "jorgeperez",
                            RolId = 2
                        });
                });

            modelBuilder.Entity("Aplicacion_Sistemas.Models.Producto", b =>
                {
                    b.HasOne("Aplicacion_Sistemas.Models.TipoProducto", "TipoProducto")
                        .WithMany("Producto")
                        .HasForeignKey("TipoProductoId")
                        .HasConstraintName("FK_TipoProducto_Producto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Aplicacion_Sistemas.Models.Usuario", b =>
                {
                    b.HasOne("Aplicacion_Sistemas.Models.Rol", "Rol")
                        .WithMany("Usuario")
                        .HasForeignKey("RolId")
                        .HasConstraintName("FK_RolUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}