using System.ComponentModel.DataAnnotations;

namespace ProjetoCallCenter.MVC.ViewModels
{
    public class CredencialViewModel
    {
        public int UsuarioId { get; set; }
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }

        [Required(ErrorMessage = "Escolha o Tipo")]
        [Display(Name = "Tipo: ")]
        public int TipoCredencialId { get; set; }

        [Required(ErrorMessage = "Escolha o Status")]
        [Display(Name = "Status: ")]
        public int StatusId { get; set; }

    }
}