
using Autofac;
using AutoMapper;
using DetalhesPagamento.Mapping;
using PagamentoData.Repository;
using PagamentoDomain.IRepository;

namespace PagamentoData.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC


            builder.RegisterType<RepositoryDetalhesPagamento>().As<IRepositoryDetalhesPagamento>();


            builder.Register(ctx => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DtoToModelMappingDetalhesPagamento());
                cfg.AddProfile(new ModelToDtoMappingDetalhesPagamento());

            }));
            builder.Register(ctx => ctx.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>().InstancePerLifetimeScope();

            #endregion IOC
        }
    }
}
