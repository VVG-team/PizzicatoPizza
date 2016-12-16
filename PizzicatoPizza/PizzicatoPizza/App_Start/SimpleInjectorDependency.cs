using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;
using System.Web.Mvc;
using DAL.Interface;
using DAL;
using SimpleInjector.Integration.Web;
using PizzicatoPizza.BAL.Interfaces;
using PizzicatoPizza.BAL.Managers;

namespace PizzicatoPizza.App_Start
{
    public class SimpleInjectorDependency
	{
		public static void RegistrationContainers()
		{
			var container = new Container();
			container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
			container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);
			container.Register<IPizzaManager, PizzaManager>();
			container.Verify();

			DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
		
		}
	

	}
}