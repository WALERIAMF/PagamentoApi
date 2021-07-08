using System;

namespace PagamentoDomain.Model
{
    public class DetalhesPagamentoModel : BaseModel
    {
        public string NomeDonoCartao{ get; set; }
        public string NumeroCartao { get; set; }
        public DateTime DataExpiracao { get; set; }
        public string CodigoSeguranca { get; set; }
    }
}
