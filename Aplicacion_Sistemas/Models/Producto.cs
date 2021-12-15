using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Aplicacion_Sistemas.Models
{
    public partial class Producto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(200)]
        public string Marca { get; set; }

        [Required]
        [Column(TypeName = "decimal(11, 2)")]
        public double Precio { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [Required]
        [Display(Name = "Seleccionar Tipo de Producto")]
        public int TipoProductoId { get; set; }

        [ForeignKey("TipoProductoId")]
        public virtual TipoProducto TipoProducto { get; set; }
    }
}
