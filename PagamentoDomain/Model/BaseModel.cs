using System;

namespace PagamentoDomain.Model
{
    public class BaseModel
    {
        public string Id { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime? DataAtualizacao { get; set; }

        public bool Ativo { get; set; }
    }
}
