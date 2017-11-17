using System.Collections.Generic;
using ProjetoCallCenter.Application.Interfaces;
using ProjetoCallCenter.Domain.Entities;
using ProjetoCallCenter.Domain.Interfaces.Services;

namespace ProjetoCallCenter.Application
{
    public class SegmentacaoAppService : AppServiceBase<Segmentacao>, ISegmentacaoAppService
    {
        private readonly ISegmentacaoService _service;
        public SegmentacaoAppService(ISegmentacaoService service)
            : base(service)
        {
            _service = service;
        }

        public IEnumerable<Segmentacao> GetAll(int usuario, int credor)
        {
            return _service.GetAll(usuario, credor);
        }
    }
}
