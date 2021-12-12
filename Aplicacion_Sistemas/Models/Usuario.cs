using Aplicacion_Sistemas.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Aplicacion_Sistemas.Models
{
    public partial class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(200)]
        public string Apellido { get; set; }

        [Required]
        [MaxLength(200)]
        [Display(Name = "Nombre de Usuario")]
        public string NombreDeUsuario { get; set; }

        [Required]
        [MaxLength(200)]
        [Display(Name = "Contrasena")]
        [ContrasenaValidate(ErrorMessage = "Contrasena no valida")]
        public string Contrasena { get; set; }

        [Required]
        [Display(Name = "Seleccionar Rol")]
        public int RolId { get; set; }

        [ForeignKey("RolId")]
        public virtual Rol Rol { get; set; }
    }

}
