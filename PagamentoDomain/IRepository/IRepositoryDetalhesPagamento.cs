using PagamentoDomain.Model;
using PagamentoDomainModel;
using System.Threading.Tasks;

namespace PagamentoDomain.IRepository
{
    public interface IRepositoryDetalhesPagamento : IRepositoryBase<DetalhesPagamentoModel>
    {
        Task<bool> DetalhesPagamentoUsandoGrupoPermissao(string grupoPermissaoId);
        Task<DetalhesPagamentoModel> BuscarPorNome(string login);
        Task<ModelCount<DetalhesPagamentoModel>> BuscaComFiltro(int? skip, int? take, string filtro);
    }
}
