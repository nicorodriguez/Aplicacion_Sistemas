using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Aplicacion_Sistemas.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Aplicacion_Sistemas.Services;
using System.Threading.Tasks;

namespace Aplicacion_Sistemas.Controllers
{
    public class LoginController : Controller
    {
        const string SessionUser = "_Usuario";
        const string SessionRol = "_Rol";
        private readonly UsuariosService _usuariosService;

        public IConfiguration Configuration { get; }

        /// <summary>
        /// Interfaz para acceder a los valores del archivo de configuración
        /// </summary>
        /// <param name="configuration"></param>
        public LoginController(IConfiguration configuration, UsuariosService usuarioService)
        {
            Configuration = configuration;
            _usuariosService = usuarioService;
        }

        /// <summary>
        /// Action para inicializar la carga de la vista del Login en base a los atributos de modelo usuario
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {
            return View(new Usuario());
        }



        /// <summary>
        /// Action de tipo POST para  para inicializar el proceso de validación e iniciar sesión en  base a los datos del modelo
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(Usuario model)
        {
            if (string.IsNullOrEmpty(model.NombreDeUsuario) || string.IsNullOrEmpty(model.Contrasena))
            {
                ModelState.AddModelError("", "Datos faltantes");//Error personalizado
                return View(model);
            }

            var result = await _usuariosService.FindByNombreDeUsuario(model.NombreDeUsuario, model.Contrasena);

            //Match entre los valores ingresados y la lista
            if (result == null)
            {
                ModelState.AddModelError("", "Datos ingresados incorrectos");//Error personalizado
            }
            else if(result.NombreDeUsuario == model.NombreDeUsuario && result.Contrasena == model.Contrasena)
            {
                HttpContext.Session.SetString(SessionUser, result.NombreDeUsuario); //Iniciamos la sesión pasando el valor (nombre del usuario)
                HttpContext.Session.SetString(SessionRol, result.Rol.Nombre); //Iniciamos la sesión pasando el valor (nombre del usuario)

                return RedirectToAction("Index", "Home"); //Redireccionar a la vista inicial
            }
            else
            {
                ModelState.AddModelError("", "Datos ingresados incorrectos");//Error personalizado
            }

            return View(model);
        }



        /// <summary>
        /// Action para limpiar y cerrar la sesión de la aplicación
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            HttpContext.Session.Clear();//Limpiar la sesión

            return RedirectToAction("Login", "Login");//Redireccionar a la vista login
        }
    }
}
