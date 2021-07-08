using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PagamentoDomain.Model;

namespace DetalhesPagamento.Mapping
{
    public class DetalhesPagamentoMap : IEntityTypeConfiguration<DetalhesPagamentoModel>
    {
     
        public void Configure(EntityTypeBuilder<DetalhesPagamentoModel> builder)
        {
            builder.ToTable("DetalhesPagamento");

            builder.HasKey(i => i.Id);

            builder.Property(x => x.NomeDonoCartao)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(x => x.NumeroCartao)
               .HasColumnType("varchar(14)")
               .IsRequired();

            builder.Property(x => x.CodigoSeguranca)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(x => x.DataCadastro)
               .HasColumnType("datetime")
                .IsRequired();

            builder.Property(x => x.DataAtualizacao)
               .HasColumnType("datetime")
               .IsRequired();

            builder.Property(x => x.DataExpiracao)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(x => x.Ativo)
                .IsRequired();
        }
    }
}
