using ProjetoCallCenter.Domain.Entities;
using ProjetoCallCenter.Domain.Interfaces.Repositories;
using ProjetoCallCenter.Domain.Interfaces.Services;
using System.Linq;

namespace ProjetoCallCenter.Domain.Services
{
    public class CredencialService : ServiceBase<Credencial>, ICredencialService
    {
        private ICredencialRepository _credencialRepository;

        public CredencialService(ICredencialRepository credencialRepository) 
            : base(credencialRepository)
        {
            _credencialRepository = credencialRepository;
        }

        public Credencial EfetuarLogin(string usuario, string senha)
        {
            return _credencialRepository.GetAll()
                .Where(c=> c.NomeUsuario == usuario  &&  c.Senha == senha)
                .FirstOrDefault();
        }

        public bool UsuarioExiste(string usuario)
        {
            var credencial = _credencialRepository.GetAll()
                .Where( c=> c.NomeUsuario == usuario)
                .FirstOrDefault();

            if (credencial != null)
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
