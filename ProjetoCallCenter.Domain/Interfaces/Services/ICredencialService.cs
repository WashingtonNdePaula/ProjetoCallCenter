using ProjetoCallCenter.Domain.Entities;

namespace ProjetoCallCenter.Domain.Interfaces.Services
{
    public interface ICredencialService : IServiceBase<Credencial>
    {
        Credencial EfetuarLogin(string usuario, string senha);
        bool UsuarioExiste(string usuario);

    }
}
