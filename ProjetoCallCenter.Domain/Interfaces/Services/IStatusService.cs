using ProjetoCallCenter.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoCallCenter.Domain.Interfaces.Services
{
    public interface IStatusService : IServiceBase<Status>
    {
        IEnumerable<Status> GetAllForAtendimento();
        IEnumerable<Status> GetAllForUsuario();
        IEnumerable<Status> GetAllForDivida();

    }
}
