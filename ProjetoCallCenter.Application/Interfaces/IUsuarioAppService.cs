using ProjetoCallCenter.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoCallCenter.Application.Interfaces
{
    public interface IUsuarioAppService : IAppServiceBase<Usuario>
    {
        IEnumerable<Usuario> GetAllValidos();
        IEnumerable<Usuario> GetAllOperadores();
        bool EmailJaCadastrado(int id, string email);
    }
}
