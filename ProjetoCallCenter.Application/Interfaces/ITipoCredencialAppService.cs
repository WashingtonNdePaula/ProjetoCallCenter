using ProjetoCallCenter.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoCallCenter.Application.Interfaces
{
    public interface ITipoCredencialAppService : IAppServiceBase<TipoCredencial>
    {
        IEnumerable<TipoCredencial> GetAllValidos();
    }
}
