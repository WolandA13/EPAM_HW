using Ninject;
using Ninject.Modules;
using Ninject.Web.Mvc;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Totalizator.Business.Infrastructure;
using Totalizator.Web.Util;

namespace Totalizator.Web
{
	public class MvcApplication : HttpApplication
	{
		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);

			NinjectModule repositoryModule = new RepositoryModule("DefaultConnection");
			NinjectModule serviceModule = new ServiceModule();
			var kernel = new StandardKernel(serviceModule, repositoryModule);
			DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
		}
	}
}