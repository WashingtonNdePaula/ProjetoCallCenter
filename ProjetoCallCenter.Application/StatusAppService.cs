using System.Collections.Generic;
using ProjetoCallCenter.Application.Interfaces;
using ProjetoCallCenter.Domain.Entities;
using ProjetoCallCenter.Domain.Interfaces.Services;

namespace ProjetoCallCenter.Application
{
    public class StatusAppService : AppServiceBase<Status>, IStatusAppService
    {
        private readonly IStatusService _service;
        public StatusAppService(IStatusService service)
            :base(service)
        {
            _service = service;
        }

        public IEnumerable<Status> GetAllForAtendimento()
        {
            return _service.GetAllForAtendimento();
        }

        public IEnumerable<Status> GetAllForDivida()
        {
            return _service.GetAllForDivida();
        }

        public IEnumerable<Status> GetAllForUsuario()
        {
            return _service.GetAllForUsuario();
        }
    }
}
