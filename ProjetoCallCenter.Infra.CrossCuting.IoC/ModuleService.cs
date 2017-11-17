using Ninject.Modules;
using ProjetoCallCenter.Application;
using ProjetoCallCenter.Application.Interfaces;
using ProjetoCallCenter.Domain.Interfaces.Repositories;
using ProjetoCallCenter.Domain.Interfaces.Services;
using ProjetoCallCenter.Domain.Services;
using ProjetoCallCenter.Infra.Data.Repositories;

namespace ProjetoCallCenter.Infra.CrossCuting.IoC
{
    public class ModuleService : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            Bind<ICredencialRepository>().To<CredencialRepository>();
            Bind<ICredorRepository>().To<CredorRepository>();
            Bind<IPerfilNegociacaoRepository>().To<PerfilNegociacaoRepository>();
            Bind<ISegmentacaoRepository>().To<SegmentacaoRepository>();
            Bind<IUsuarioRepository>().To<UsuarioRepository>();
            Bind<IStatusRepository>().To<StatusRepository>();
            Bind<ITipoCredencialRepository>().To<TipoCredencialRepository>();

            Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            Bind<ICredencialService>().To<CredencialService>();
            Bind<ICredorService>().To<CredorService>();
            Bind<IPerfilNegociacaoService>().To<PerfilNegociacaoService>();
            Bind<ISegmentacaoService>().To<SegmentacaoService>();
            Bind<IUsuarioService>().To<UsuarioService>();
            Bind<IStatusService>().To<StatusService>();
            Bind<ITipoCredencialService>().To<TipoCredencialService>();

            Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            Bind<ICredencialAppService>().To<CredencialAppService>();
            Bind<ICredorAppService>().To<CredorAppService>();
            Bind<IPerfilNegociacaoAppService>().To<PerfilNegociacaoAppService>();
            Bind<ISegmentacaoAppService>().To<SegmentacaoAppService>();
            Bind<IUsuarioAppService>().To<UsuarioAppService>();
            Bind<IStatusAppService>().To<StatusAppService>();
            Bind<ITipoCredencialAppService>().To<TipoCredencialAppService>();

        }
    }
}