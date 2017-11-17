using ProjetoCallCenter.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoCallCenter.Application.Interfaces
{
    public interface IStatusAppService : IAppServiceBase<Status>
    {
        IEnumerable<Status> GetAllForAtendimento();
        IEnumerable<Status> GetAllForDivida();
        IEnumerable<Status> GetAllForUsuario();
    }
}
