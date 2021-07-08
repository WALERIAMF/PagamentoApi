using System;

namespace PagamentoData.Entity
{
    public class BaseEntity
    {
        public string Id { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime? DataAtualizacao { get; set; }

        public bool Ativo { get; set; }
    }
}
