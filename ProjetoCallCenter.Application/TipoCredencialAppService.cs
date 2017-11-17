using System.Collections.Generic;
using ProjetoCallCenter.Application.Interfaces;
using ProjetoCallCenter.Domain.Entities;
using ProjetoCallCenter.Domain.Interfaces.Services;

namespace ProjetoCallCenter.Application
{
    public class TipoCredencialAppService : AppServiceBase<TipoCredencial>, ITipoCredencialAppService
    {
        private readonly ITipoCredencialService _service;
        public TipoCredencialAppService(ITipoCredencialService service)
            :base(service)
        {
            _service = service;
        }

        public IEnumerable<TipoCredencial> GetAllValidos()
        {
            return _service.GetAllValidos();
        }
    }
}
