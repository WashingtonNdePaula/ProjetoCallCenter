using ProjetoCallCenter.Domain.Entities;
using ProjetoCallCenter.Domain.Interfaces.Services;
using ProjetoCallCenter.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoCallCenter.Domain.Services
{
    public class StatusService : ServiceBase<Status>, IStatusService
    {
        private readonly IStatusRepository _repository;
        public StatusService(IStatusRepository repository) 
            : base(repository)
        {
            _repository = repository;
        }

        public IEnumerable<Status> GetAllForAtendimento()
        {
            return _repository.GetAll().Where(s => s.Tipo == "Atendimento");
        }

        public IEnumerable<Status> GetAllForDivida()
        {
            return _repository.GetAll().Where(s => s.Tipo == "Divida");
        }

        public IEnumerable<Status> GetAllForUsuario()
        {
            return _repository.GetAll().Where(s => s.Tipo == "Usuario");
        }
    }
}
