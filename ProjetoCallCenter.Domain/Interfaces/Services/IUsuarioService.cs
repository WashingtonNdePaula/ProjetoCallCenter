using ProjetoCallCenter.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoCallCenter.Domain.Interfaces.Services
{
    public interface IUsuarioService : IServiceBase<Usuario>
    {
        IEnumerable<Usuario> GetAllValidos();
        IEnumerable<Usuario> GetAllOperadores();
        bool EmailJaCadastrado(int id, string email);
    }
}
