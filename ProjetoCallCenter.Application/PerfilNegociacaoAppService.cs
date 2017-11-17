using System.Collections.Generic;
using ProjetoCallCenter.Application.Interfaces;
using ProjetoCallCenter.Domain.Entities;
using ProjetoCallCenter.Domain.Interfaces.Services;

namespace ProjetoCallCenter.Application
{
    public class PerfilNegociacaoAppService : AppServiceBase<PerfilNegociacao>, IPerfilNegociacaoAppService
    {
        private readonly IPerfilNegociacaoService _service;
        public PerfilNegociacaoAppService(IPerfilNegociacaoService service)
            : base(service)
        {
            _service = service;
        }

        public IEnumerable<PerfilNegociacao> GetAll(int credor)
        {
            return _service.GetAll(credor);
        }
    }
}
