using Autofac.Integration.Mvc;
using Autofac;
using System.Data.Entity;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TestIocDi.Context;
using TestIocDi.Repository;
using TestIocDi.Service;


namespace TestIocDi
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
    
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly); //Регистрация контроллеров
            builder.RegisterType<PersonRepository>().As<IPersonRepository>(); //Регистрация реализации зависимости
            builder.RegisterType<PersonService>(); //Регистрация сервиса
            builder.RegisterType<BookRepository>().As<IBookRepository>(); //Регистрация реализации зависимости
            builder.RegisterType<BookService>(); //Регистрация сервис
            var contaiter = builder.Build(); //Создание сервиса
            DependencyResolver.SetResolver(new AutofacDependencyResolver(contaiter)); //Замена стандартного поставщика зависимости на поставщика AutoFac

            Database.SetInitializer(new MyContextInitializer());
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

        }
    }
}
