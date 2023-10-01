using MyFirstWebApp.Repository;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace MyFirstWebApp
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterType<IEmpRepository, EmpRepository>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}