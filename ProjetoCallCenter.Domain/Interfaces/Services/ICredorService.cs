using ProjetoCallCenter.Domain.Entities;

namespace ProjetoCallCenter.Domain.Interfaces.Services
{
    public interface ICredorService : IServiceBase<Credor>
    {
        bool CNPJJaExiste(string cnpj);

    }
}
