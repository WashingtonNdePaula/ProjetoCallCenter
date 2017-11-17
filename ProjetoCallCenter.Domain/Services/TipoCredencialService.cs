using System.Collections.Generic;
using ProjetoCallCenter.Domain.Entities;
using ProjetoCallCenter.Domain.Interfaces.Repositories;
using ProjetoCallCenter.Domain.Interfaces.Services;
using System.Linq;

namespace ProjetoCallCenter.Domain.Services
{
    public class TipoCredencialService : ServiceBase<TipoCredencial>, ITipoCredencialService
    {
        private readonly ITipoCredencialRepository _repository;
        public TipoCredencialService(ITipoCredencialRepository repository)
            :base(repository)
        {
            _repository = repository;
        }

        public IEnumerable<TipoCredencial> GetAllValidos()
        {
            return _repository.GetAll().Where(t => t.Descricao != "Administrador");
        }
    }
}
