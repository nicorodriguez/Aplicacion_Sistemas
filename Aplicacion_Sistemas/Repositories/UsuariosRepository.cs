using Microsoft.EntityFrameworkCore;
using Aplicacion_Sistemas.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace Aplicacion_Sistemas.Repositories
{
    public class UsuariosRepository : BaseRepository<Usuario>, IUsuariosRepository
    {
        private readonly Proyecto_SistemasContext _context;

        public UsuariosRepository(Proyecto_SistemasContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Usuario> FindByNombreDeUsuario(string nombreDeUsuario, string contrasena)
        {
            return await _context.Usuario
                            .Where(u => u.NombreDeUsuario == nombreDeUsuario && u.Contrasena == contrasena)
                            .Include(u => u.Rol)
                            .SingleOrDefaultAsync();
        }
    }
}
