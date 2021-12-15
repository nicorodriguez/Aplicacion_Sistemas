using Aplicacion_Sistemas.Models;
using System;
using System.Threading.Tasks;

namespace Aplicacion_Sistemas.Services
{
    public interface IUsuariosService
    {
        Task<Usuario> FindByNombreDeUsuario(string nombreDeUsuario, string contrasena);
    }
}
