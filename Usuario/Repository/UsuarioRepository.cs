
using Microsoft.EntityFrameworkCore;
using Usuario.Data;
using Usuario.Model;

namespace Usuario.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly usuarioDbContext _context;

        public UsuarioRepository(usuarioDbContext context)
        {
            _context = context;
        }

        public void AdicionaUsuario(usuario usuario)
        {
            _context.Add(usuario);
        }

        public void AtualizaUsuario(usuario usuario)
        {
            _context.Update(usuario);
        }

        public async Task<usuario> BuscaUsuario(int id)
        {
            return await _context.Usuarios.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<usuario>> BuscaUsuarios()
        {
            return await _context.Usuarios.ToListAsync();
        }

        public void DeletaUsuario(usuario usuario)
        {
            _context.Remove(usuario);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}