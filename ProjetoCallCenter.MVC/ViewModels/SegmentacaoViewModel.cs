
using ProjetoCallCenter.Domain.Entities;
using ProjetoCallCenter.MVC.Validations;
using System.ComponentModel.DataAnnotations;

namespace ProjetoCallCenter.MVC.ViewModels
{
    public class SegmentacaoViewModel
    {
        public int SegmentacaoId { get; set; }

        [Display(Name ="Usuário: ")]
        public int UsuarioId { get; set; }

        [Display(Name = "Credor: ")]
        public int CredorId { get; set; }

        [Display(Name = "Dias em atrado de")]
        [Range(minimum: 1, maximum: 9999, ErrorMessage = "O dia deve estar entre {1} e {2}")]
        public int DiaEmAtrasoDe { get; set; }

        [Display(Name = "Dias em atrado até")]
        [Range(minimum: 1, maximum: 9999, ErrorMessage = "O dia deve estar entre {1} e {2}")]
        public int DiaEmAtrasoAte { get; set; }

        [Display(Name = "Valor da dívida de")]
        [Range(minimum:0.01,maximum:999999.99,ErrorMessage ="O valor deve estar entre {1:c} e {2:c}")]
        [DisplayFormat(DataFormatString = "{0:N}", ApplyFormatInEditMode = true)]
        [NumeroBrasil(DecimalRequerido =true, PontoMilharPermitido =true, ErrorMessage = "Valor inválido")]
        public double ValorDividaDe { get; set; }

        [Display(Name = "Valor da dívida até")]
        [Range(minimum: 0.01, maximum: 999999.99, ErrorMessage = "O valor deve estar entre {1:c} e {2:c}")]
        [DisplayFormat(DataFormatString ="{0:N}",ApplyFormatInEditMode =true)]
        [NumeroBrasil(DecimalRequerido = true, PontoMilharPermitido = true, ErrorMessage = "Valor inválido")]
        public double ValorDividaAte { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Credor Credor { get; set; }
    }
}