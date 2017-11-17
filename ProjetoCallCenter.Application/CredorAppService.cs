using ProjetoCallCenter.Application.Interfaces;
using ProjetoCallCenter.Domain.Entities;
using ProjetoCallCenter.Domain.Interfaces.Services;

namespace ProjetoCallCenter.Application
{
    public class CredorAppService : AppServiceBase<Credor>, ICredorAppService
    {
        private readonly ICredorService _service;
        public CredorAppService(ICredorService service)
            : base(service)
        {
            _service = service;
        }

        public bool CNPJJaExiste(string cnpj)
        {
            return _service.CNPJJaExiste(cnpj);
        }

        public Credor LocalizarCEP(Credor credor)
        {
            var service = new br.com.correios.apps.AtendeClienteService();
            var endereco = service.consultaCEP(credor.CEP);
            credor.Logradouro = endereco.end;
            credor.Bairro = endereco.bairro;
            credor.Cidade = endereco.cidade;
            credor.UF = endereco.uf;
            return credor;
        }
    }
}
