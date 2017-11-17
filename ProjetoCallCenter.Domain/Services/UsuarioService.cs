using System.Collections.Generic;
using ProjetoCallCenter.Domain.Entities;
using ProjetoCallCenter.Domain.Interfaces.Repositories;
using ProjetoCallCenter.Domain.Interfaces.Services;
using System.Linq;

namespace ProjetoCallCenter.Domain.Services
{
    public class UsuarioService : ServiceBase<Usuario>, IUsuarioService
    {

        private IUsuarioRepository _usuarioRepository;
        public UsuarioService(IUsuarioRepository usuariorepository)
            :base(usuariorepository)
        {
            _usuarioRepository = usuariorepository;
        }

        public bool EmailJaCadastrado(int id, string email)
        {
            if (_usuarioRepository.GetAll().Where(u => u.UsuarioId != id && u.Email == email).FirstOrDefault() != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public IEnumerable<Usuario> GetAllValidos()
        {
            return _usuarioRepository.GetAll().Where(u => u.Credencial.TipoCredencial.Descricao != "Administrador");
        }

        public IEnumerable<Usuario> GetAllOperadores()
        {
            return _usuarioRepository.GetAll().Where(u => u.Credencial.TipoCredencial.Descricao == "Operador");
        }

    }
}
