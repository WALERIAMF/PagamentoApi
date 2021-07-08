using System;

namespace PagamentoData.Entity
{
    public class DetalhesPagamentoEntity : BaseEntity
    { 
        public string NomeDonoCartao { get; set; }
        public string NumeroCartao { get; set; }
        public DateTime DataExpiracao { get; set; }
        public string CodigoSeguranca { get; set; }
    }
}
