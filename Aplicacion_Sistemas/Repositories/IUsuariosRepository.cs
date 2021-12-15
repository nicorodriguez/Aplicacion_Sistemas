using Aplicacion_Sistemas.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Aplicacion_Sistemas.Repositories
{
    public interface IUsuariosRepository
    {
        Task<Usuario> FindByNombreDeUsuario(string nombreDeUsuario, string contrasena);
    }
}
