using AutoMapper;
using PagamentoData.Entity;
using PagamentoDomain.Model;

namespace DetalhesPagamento.Mapping
{
    public class DtoToModelMappingDetalhesPagamento : Profile
    {
        public DtoToModelMappingDetalhesPagamento()
        {
            ClientMap();
        }

        private void ClientMap()
        {
            CreateMap<DetalhesPagamentoEntity, DetalhesPagamentoModel>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.NomeDonoCartao, opt => opt.MapFrom(x => x.NomeDonoCartao))
                .ForMember(dest => dest.NumeroCartao, opt => opt.MapFrom(x => x.NumeroCartao))
                .ForMember(dest => dest.CodigoSeguranca, opt => opt.MapFrom(x => x.CodigoSeguranca))
                .ForMember(dest => dest.DataCadastro, opt => opt.Ignore())
                .ForMember(dest => dest.DataAtualizacao, opt => opt.Ignore())
                .ForMember(dest => dest.DataExpiracao, opt => opt.Ignore())
                .ForMember(dest => dest.Ativo, opt => opt.Ignore());
        }
    }

}


