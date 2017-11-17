using System.Collections.Generic;
using ProjetoCallCenter.Domain.Entities;
using ProjetoCallCenter.Domain.Interfaces.Repositories;
using ProjetoCallCenter.Domain.Interfaces.Services;
using System.Linq;

namespace ProjetoCallCenter.Domain.Services
{
    public class SegmentacaoService : ServiceBase<Segmentacao>, ISegmentacaoService
    {
        private ISegmentacaoRepository _repository;

        public SegmentacaoService(ISegmentacaoRepository repository) 
            : base(repository)
        {
            _repository = repository;
        }

        public IEnumerable<Segmentacao> GetAll(int usuario, int credor)
        {
            return _repository.GetAll().Where(s => s.UsuarioId == usuario && s.CredorId == credor);
        }
    }
}
