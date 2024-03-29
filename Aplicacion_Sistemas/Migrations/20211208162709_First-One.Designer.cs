﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proyecto_Sistemas.Models;

namespace Aplicacion_Sistemas.Migrations
{
    [DbContext(typeof(Proyecto_SistemasContext))]
    [Migration("20211208162709_First-One")]
    partial class FirstOne
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Proyecto_Sistemas.Models.Producto", b =>
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
                });

            modelBuilder.Entity("Proyecto_Sistemas.Models.Rol", b =>
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
                });

            modelBuilder.Entity("Proyecto_Sistemas.Models.TipoProducto", b =>
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
                });

            modelBuilder.Entity("Proyecto_Sistemas.Models.Usuario", b =>
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
                });

            modelBuilder.Entity("Proyecto_Sistemas.Models.Producto", b =>
                {
                    b.HasOne("Proyecto_Sistemas.Models.TipoProducto", "TipoProducto")
                        .WithMany("Producto")
                        .HasForeignKey("TipoProductoId")
                        .HasConstraintName("FK_TipoProducto_Producto")
                        .IsRequired();
                });

            modelBuilder.Entity("Proyecto_Sistemas.Models.Usuario", b =>
                {
                    b.HasOne("Proyecto_Sistemas.Models.Rol", "Rol")
                        .WithMany("Usuario")
                        .HasForeignKey("RolId")
                        .HasConstraintName("FK_RolUsuario")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
