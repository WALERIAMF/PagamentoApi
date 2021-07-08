using AutoMapper;
using PagamentoData.Entity;
using PagamentoDomain.Model;

namespace DetalhesPagamento.Mapping
{
    public class ModelToDtoMappingDetalhesPagamento : Profile

    {
        public ModelToDtoMappingDetalhesPagamento()
        {
            ClientDtoMap();
        }
        private void ClientDtoMap()
        {
            CreateMap<DetalhesPagamentoModel, DetalhesPagamentoEntity>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.NomeDonoCartao, opt => opt.MapFrom(x => x.NomeDonoCartao))
                .ForMember(dest => dest.NumeroCartao, opt => opt.MapFrom(x => x.NumeroCartao));

        }
    }
}