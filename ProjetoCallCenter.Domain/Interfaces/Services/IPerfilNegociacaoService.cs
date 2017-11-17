using ProjetoCallCenter.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoCallCenter.Domain.Interfaces.Services
{
    public interface IPerfilNegociacaoService : IServiceBase<PerfilNegociacao>
    {
        IEnumerable<PerfilNegociacao> GetAll(int credor);
    }

}
