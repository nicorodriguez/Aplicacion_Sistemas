using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Aplicacion_Sistemas.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Aplicacion_Sistemas.Controllers
{
    public class LoginController : Controller
    {
        /// <summary>
        /// Constante para Inicializar la Sesión _User
        /// </summary>
        const string SessionUser = "_User";

        public IConfiguration Configuration { get; }

        /// <summary>
        /// Interfaz para acceder a los valores del archivo de configuración
        /// </summary>
        /// <param name="configuration"></param>
        public LoginController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>

        /// Action para inicializar la carga de la vista del Login en base a los atributos de modelo usuario

        /// </summary>

        /// <returns></returns>

        public ActionResult Login()

        {

            //ViewBag.ReturnUrl = returnUrl;

            return View(new Usuario());

        }



        /// <summary>

        /// Action de tipo POST para  para inicializar el proceso de validación e iniciar sesión en  base a los datos del modelo

        /// </summary>

        /// <param name="model"></param>

        /// <returns></returns>

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Login(Usuario model)
        {
            //Conexión a la base de datos
            string connectionString = Configuration["ConnectionStrings:ProjectContext"];

            //Estoy usando uso de ADO.Net para interactuar con la base de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var list_users = new List<Usuario>();

                //Validar los controladores
                if (model.NombreDeUsuario == null || model.NombreDeUsuario.Equals("") || model.Contrasena == null || model.Contrasena.Equals(""))
                {
                    ModelState.AddModelError("", "Ingresar los datos solicitados");
                }
                else
                {
                    connection.Open();//Abrir la conexión a la base de datos

                    SqlCommand com = new SqlCommand("GET_USUARIO", connection);//Referencia al procedimiento almacenado

                    com.CommandType = CommandType.StoredProcedure;//Se define el tipo de comando a utilizar

                    //Paso los parámetros de acuerdo a los datos cargados segun el modelo usario

                    com.Parameters.AddWithValue("@usuario", model.NombreDeUsuario);
                    com.Parameters.AddWithValue("@contrasena", model.Contrasena);

                    SqlDataReader dr = com.ExecuteReader();//Ejecuto el comando a través de un DataReader
                    //Recorro los datos y adiciono en la lista list_users los valores usuario y contrasena

                    while (dr.Read())
                    {
                        Usuario usuario = new Usuario();

                        usuario.NombreDeUsuario = Convert.ToString(dr["nombre_de_usuario"]);
                        usuario.Contrasena = Convert.ToString(dr["contrasena"]);

                        list_users.Add(usuario);
                    }

                    //Match entre los valores ingresados y la lista
                    if (list_users.Any(p => p.NombreDeUsuario == model.NombreDeUsuario && p.Contrasena == model.Contrasena))
                    {
                        HttpContext.Session.SetString(SessionUser, model.NombreDeUsuario); //Iniciamos la sesión pasando el valor (nombre del usuario)

                        return RedirectToAction("Index", "Home"); //Redireccionar a la vista inicial
                    }
                    else
                    {
                        ModelState.AddModelError("", "Datos ingresado no válido.");//Error personalizado
                    }
                }
                return View(model);
            }
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
