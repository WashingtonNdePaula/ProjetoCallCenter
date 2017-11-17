using ProjetoCallCenter.Domain.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoCallCenter.MVC.ViewModels
{
    public class ListaSegmentacaoViewModel
    {
        
        [Display(Name = "Usuário: ")]
        public int UsuarioId { get; set; }

        [Display(Name = "Credor: ")]
        public int CredorId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Credor Credor { get; set; }
        public virtual IEnumerable<SegmentacaoViewModel> Segmentacoes { get; set; }    

    }
}