using ProjetoCallCenter.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoCallCenter.Domain.Interfaces.Services
{
    public interface ITipoCredencialService : IServiceBase<TipoCredencial>
    {
        IEnumerable<TipoCredencial> GetAllValidos();
    }
}
