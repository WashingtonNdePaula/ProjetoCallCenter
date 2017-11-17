using ProjetoCallCenter.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoCallCenter.Application.Interfaces
{
    public interface IPerfilNegociacaoAppService : IAppServiceBase<PerfilNegociacao>
    {
        IEnumerable<PerfilNegociacao> GetAll(int credor);
    }
}
