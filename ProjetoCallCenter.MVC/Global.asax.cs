using ProjetoCallCenter.MVC.Mappers;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ProjetoCallCenter.MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            AutoMapperConfig.RegisterMappings();

            ModelBinders.Binders.Add(typeof(double), new DoubleModelBinder());
            ModelBinders.Binders.Add(typeof(double?), new DoubleModelBinder());
            ModelBinders.Binders.Add(typeof(int), new Int32ModelBinder());
            ModelBinders.Binders.Add(typeof(int?), new Int32ModelBinder());
            ModelBinders.Binders.Add(typeof(decimal), new DecimalModelBinder());
            ModelBinders.Binders.Add(typeof(decimal?), new DecimalModelBinder());

            ClientDataTypeModelValidatorProvider.ResourceClassKey = "Mensagens";
            DefaultModelBinder.ResourceClassKey = "Mensagens";
        }
    }
}
