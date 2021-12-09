using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Proyecto_Sistemas.Models
{
    public partial class Proyecto_SistemasContext : DbContext
    {
        public Proyecto_SistemasContext()
        {
        }

        public Proyecto_SistemasContext(DbContextOptions<Proyecto_SistemasContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<TipoProducto> TipoProducto { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost\\SQLExpress;Database=Aplicacion_Sistemas;User Id=sa; Password=9461nmj;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>(entity =>
            {
                entity.Property(e => e.Id)
                      .HasColumnName("id");

                entity.Property(e => e.Cantidad)
                    .IsRequired()
                    .HasColumnName("cantidad");

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasColumnName("marca")
                    .HasMaxLength(200);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(200);

                entity.Property(e => e.Precio)
                    .HasColumnName("precio")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.TipoProductoId).HasColumnName("tipo_producto_id");

                entity.HasOne(d => d.TipoProducto)
                    .WithMany(p => p.Producto)
                    .HasForeignKey(d => d.TipoProductoId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_TipoProducto_Producto");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.Property(e => e.Id)
                      .HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<TipoProducto>(entity =>
            {
                entity.ToTable("Tipo_Producto");

                entity.Property(e => e.Id)
                      .HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property(e => e.Id)
                      .HasColumnName("id");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasColumnName("apellido")
                    .HasMaxLength(200);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(200);

                entity.Property(e => e.NombreDeUsuario)
                    .IsRequired()
                    .HasColumnName("nombre_de_usuario")
                    .HasMaxLength(200);

                entity.Property(e => e.RolId).HasColumnName("rol_id");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_RolUsuario");
            });

            modelBuilder.Entity<TipoProducto>().HasData(
                new TipoProducto() { Id = 1, Nombre = "Carnes" },
                new TipoProducto() { Id = 2, Nombre = "Verduras" },
                new TipoProducto() { Id = 3, Nombre = "Bebidas" },
                new TipoProducto() { Id = 4, Nombre = "Electrodomésticos" },
                new TipoProducto() { Id = 5, Nombre = "Golosinas" },
                new TipoProducto() { Id = 6, Nombre = "Envasados" });

            modelBuilder.Entity<Producto>().HasData(
                new Producto() { Id = 1, Nombre = "Ventilador", Marca = "La Mejor", Precio = 10.500m, Cantidad = 10, TipoProductoId = 4 },
                new Producto() { Id = 2, Nombre = "Gaseosa sabor Ginger Ale 1.5L", Marca = "Kunington", Precio = 80m, Cantidad = 30, TipoProductoId = 3 },
                new Producto() { Id = 3, Nombre = "Gaseosa sabor Cola 1.5L", Marca = "Kunington", Precio = 85m, Cantidad = 90, TipoProductoId = 3 },
                new Producto() { Id = 4, Nombre = "Papa blanca 1Kg", Marca = "Excelente", Precio = 40m, Cantidad = 20, TipoProductoId = 2 });

            modelBuilder.Entity<Rol>().HasData(
                new Rol() { Id = 1, Nombre = "Admin" },
                new Rol() { Id = 2, Nombre = "Empleado" });

            modelBuilder.Entity<Usuario>().HasData(
                new Usuario() { Id = 1, Nombre = "Carla", Apellido = "Saltirana", NombreDeUsuario = "carlasaltirana", RolId = 1},
                new Usuario() { Id = 2, Nombre = "Jorge", Apellido = "Perez", NombreDeUsuario = "jorgeperez", RolId = 2});

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
