using PagamentoDomain.Model;
using PagamentoDomain.Response;
using System.Threading.Tasks;

namespace PagamentoDomain.IService
{
    public interface IServiceDetalhesPagamento
    {
        Task<ResponseData<DetalhesPagamentoModel>> BuscarPorId(string id);
    }
}
