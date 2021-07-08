
using PagamentoData.Entity;
using PagamentoDomain.IRepository;
using PagamentoDomain.Model;
using PagamentoDomainModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PagamentoData.Repository
{
    public class RepositoryDetalhesPagamento : BaseRepository<DetalhesPagamentoModel>, IRepositoryDetalhesPagamento
    {
        private readonly PagamentoData.Context.Context _context;
        public RepositoryDetalhesPagamento(PagamentoData.Context.Context context) : base(context)
        {
            _context = context;
        }

        public Task<ModelCount<DetalhesPagamentoModel>> BuscaComFiltro(int? skip, int? take, string filtro)
        {
            throw new System.NotImplementedException();
        }

        public Task<DetalhesPagamentoModel> BuscarPorNome(string login)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DetalhesPagamentoUsandoGrupoPermissao(string grupoPermissaoId)
        {
            throw new System.NotImplementedException();
        }
    }
}
