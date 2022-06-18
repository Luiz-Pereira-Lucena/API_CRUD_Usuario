using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Usuario.Model;

namespace Usuario.Repository
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<usuario>> BuscaUsuarios();
        Task<usuario> BuscaUsuario(int id);
        void AdicionaUsuario(usuario usuario);
        void AtualizaUsuario(usuario usuario);
        void DeletaUsuario(usuario usuario);

        Task<bool> SaveChangesAsync();
    }
}