using System.Collections.Generic;

namespace ProjetoCallCenter.Domain.Entities
{
    public class Credor : Endereco
    {
        public int CredorId { get; set; }
        public string CNPJ { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Responsavel { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public virtual IEnumerable<PerfilNegociacao> PerfilNegociacao { get; set; }
        public virtual IEnumerable<Divida> Dividas { get; set; }
        public virtual IEnumerable<Segmentacao> Segmentacoes { get; set; }
    }
}