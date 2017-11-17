using ProjetoCallCenter.Application.Interfaces;
using ProjetoCallCenter.Domain.Entities;
using ProjetoCallCenter.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace ProjetoCallCenter.Application
{
    public class UsuarioAppService : AppServiceBase<Usuario>, IUsuarioAppService
    {
        private readonly IUsuarioService _service;
        public UsuarioAppService(IUsuarioService service)
            : base(service)
        {
            _service = service;
        }

        public bool EmailJaCadastrado(int id, string email)
        {
            return _service.EmailJaCadastrado(id, email);
        }

        public IEnumerable<Usuario> GetAllValidos()
        {
            return _service.GetAllValidos();
        }

        public IEnumerable<Usuario> GetAllOperadores()
        {
            return _service.GetAllOperadores();
        }

    }
}
