using ProjetoCallCenter.MVC.Validations;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ProjetoCallCenter.MVC.ViewModels
{
    public class CredorViewModel
    {
        [Display(Name = "Credor: ")]
        public int CredorId { get; set; }

        [Required(ErrorMessage = "Favor preencher o campo CNPJ")]
        [Display(Name = "CNPJ: ")]
        public string CNPJ { get; set; }

        [Required(ErrorMessage = "Favor preencher o campo Razão Social")]
        [Display(Name = "Razão Social: ")]
        [MaxLength(80, ErrorMessage = "Razão Social deve conter no máximo 80 caracteres")]
        public string RazaoSocial { get; set; }

        [Required(ErrorMessage = "Favor preencher o campo Nome Fantasia")]
        [Display(Name = "Nome Fantasia: ")]
        [MaxLength(50, ErrorMessage = "Razão Social deve conter no máximo 50 caracteres")]
        public string NomeFantasia { get; set; }

        [Required(ErrorMessage = "Favor preencher o campo Endereço")]
        [Display(Name = "Endereço: ")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Informe o número")]
        [Display(Name = "Número: ")]
        public int Numero { get; set; }

        [Display(Name = "Complemento: ")]
        public string Complemento { get; set; }

        [Required(ErrorMessage = "Favor preencher o campo Bairro")]
        [Display(Name = "Bairro: ")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Favor preencher o campo Cidade")]
        [Display(Name = "Cidade: ")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Favor preencher o campo CEP")]
        [Display(Name = "CEP: ")]
        [StringLength(9, ErrorMessage ="O CEP deve conter 8 dígitos",MinimumLength = 9)]
        public string CEP { get; set; }

        [Required(ErrorMessage = "Preencher UF")]
        [Display(Name = "UF: ")]
        public string UF { get; set; }

        [Required(ErrorMessage = "Favor preencher o campo Responsável")]
        [Display(Name = "Responsável: ")]
        public string Responsavel { get; set; }

        [Required(ErrorMessage = "Favor preencher o campo Telefone")]
        [Display(Name = "Telefone: ")]
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Favor preencher o campo E-mail")]
        [Display(Name = "E-mail: ")]
        [EmailBrasil(EmailRequerido =true,ErrorMessage ="E-mail Inválido")]
        public string Email { get; set; }

    }
}