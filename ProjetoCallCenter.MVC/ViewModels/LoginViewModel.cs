using System.ComponentModel.DataAnnotations;

namespace ProjetoCallCenter.MVC.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Favor informe o nome de usuário")]
        [Display(Name = "Usuário: ")]
        [MaxLength(15)]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "Favor informe a senha")]
        [MaxLength(15)]
        [Display(Name = "Senha: ")]
        public string Senha { get; set; }

        [Display(Name = "Lembre-me?")]
        public bool LembreMe { get; set; }
    }
}