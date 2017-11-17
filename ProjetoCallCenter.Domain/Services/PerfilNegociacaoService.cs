using System.Collections.Generic;
using ProjetoCallCenter.Domain.Entities;
using ProjetoCallCenter.Domain.Interfaces.Repositories;
using ProjetoCallCenter.Domain.Interfaces.Services;
using System.Linq;

namespace ProjetoCallCenter.Domain.Services
{
    public class PerfilNegociacaoService : ServiceBase<PerfilNegociacao>, IPerfilNegociacaoService
    {
        private IPerfilNegociacaoRepository _repository;

        public PerfilNegociacaoService(IPerfilNegociacaoRepository repository) 
            : base(repository)
        {
            _repository = repository;
        }

        public IEnumerable<PerfilNegociacao> GetAll(int credor)
        {
            return _repository.GetAll().Where(p => p.CredorId == credor);
        }
    }
}
