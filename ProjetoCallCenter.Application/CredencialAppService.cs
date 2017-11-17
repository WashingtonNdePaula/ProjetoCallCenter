using ProjetoCallCenter.Application.Interfaces;
using ProjetoCallCenter.Domain.Entities;
using ProjetoCallCenter.Domain.Interfaces.Services;

namespace ProjetoCallCenter.Application
{
    public class CredencialAppService : AppServiceBase<Credencial>, ICredencialAppService
    {
        private readonly ICredencialService _service;
        public CredencialAppService(ICredencialService service)
            :base(service)
        {
            _service = service;
        }
        public Credencial EfetuarLogin(string usuario, string senha)
        {
            return _service.EfetuarLogin(usuario, senha);
        }

        public bool UsuarioExiste(string usuario)
        {
            return _service.UsuarioExiste(usuario);
        }
    }
}
