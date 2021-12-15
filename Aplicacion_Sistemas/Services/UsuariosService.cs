using Aplicacion_Sistemas.Models;
using Aplicacion_Sistemas.Repositories;
using System.Threading.Tasks;

namespace Aplicacion_Sistemas.Services
{
    public class UsuariosService : IUsuariosService
    {
        private readonly UsuariosRepository _usuariosRepository;

        public UsuariosService(UsuariosRepository usuariosRepository)
        {
            _usuariosRepository = usuariosRepository;
        }

        public async Task<Usuario> FindByNombreDeUsuario(string nombreDeUsuario, string contrasena)
        {
            return await _usuariosRepository.FindByNombreDeUsuario(nombreDeUsuario, contrasena);
        }
    }
}
