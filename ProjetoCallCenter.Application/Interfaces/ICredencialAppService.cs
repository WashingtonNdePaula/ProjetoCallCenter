using ProjetoCallCenter.Domain.Entities;

namespace ProjetoCallCenter.Application.Interfaces
{
    public interface ICredencialAppService : IAppServiceBase<Credencial>
    {
        Credencial EfetuarLogin(string usuario, string senha);
        bool UsuarioExiste(string usuario);

    }
}
