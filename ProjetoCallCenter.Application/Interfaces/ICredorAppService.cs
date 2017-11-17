using ProjetoCallCenter.Domain.Entities;

namespace ProjetoCallCenter.Application.Interfaces
{
    public interface ICredorAppService : IAppServiceBase<Credor>
    {
        bool CNPJJaExiste(string cnpj);
        Credor LocalizarCEP(Credor credor);
    }
}
