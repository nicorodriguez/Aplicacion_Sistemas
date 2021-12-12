using Microsoft.EntityFrameworkCore;
using Aplicacion_Sistemas.Models;

namespace Aplicacion_Sistemas.Repositories
{
    public class UsuariosRepository : IUsuariosRepository
    {
        private readonly Proyecto_SistemasContext _context;

        public UsuariosRepository(Proyecto_SistemasContext context)
        {
            _context = context;
        }

        public void GetAll()
        {
            var proyecto_SistemasContext = _context.Usuario.Include(u => u.Rol);
        }
    }
}
