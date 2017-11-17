using ProjetoCallCenter.Domain.Entities;
using ProjetoCallCenter.Domain.Interfaces.Repositories;
using ProjetoCallCenter.Domain.Interfaces.Services;
using System.Linq;

namespace ProjetoCallCenter.Domain.Services
{
    public class CredorService : ServiceBase<Credor>, ICredorService
    {
        private ICredorRepository _repository;

        public CredorService(ICredorRepository repository) 
            : base(repository)
        {
            _repository = repository;
        }

        public bool CNPJJaExiste(string cnpj)
        {
            if (_repository.GetAll().Where(c => c.CNPJ  == cnpj).FirstOrDefault() != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
