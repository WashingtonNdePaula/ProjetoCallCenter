using ProjetoCallCenter.Domain.Entities;
using ProjetoCallCenter.MVC.Validations;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ProjetoCallCenter.MVC.ViewModels
{
    public class UsuarioViewModel
    {
        [Display(Name = "Usuário: ")]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [Display(Name = "Nome: ")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo E-mail")]
        [Display(Name = "E-mail: ")]
        [EmailBrasil(EmailRequerido =true, ErrorMessage = "E-mail inválido")]
        [Remote("EmailJaCadastrado", "Usuario", AdditionalFields ="UsuarioId", ErrorMessage ="O e-mail informado já existe")]
        public string Email { get; set; }

        public virtual Credencial Credencial { get; set; }
    }
}