using MisteryBoxDomain.Services;
using MisteryBoxInfraestructure.Services;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace MisteryBoxAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            container.RegisterType<IServiceCocina, ServiceCocina>();
            container.RegisterType<IServiceRopa, ServiceRopa>();
            container.RegisterType<IServiceTecnologia, ServiceTecnologia>();
            // e.g. container.RegisterType<ITestService, TestService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}