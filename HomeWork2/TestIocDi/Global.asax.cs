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
            builder.RegisterControllers(typeof(MvcApplication).Assembly); //����������� ������������
            builder.RegisterType<PersonRepository>().As<IPersonRepository>(); //����������� ���������� �����������
            builder.RegisterType<PersonService>(); //����������� �������
            builder.RegisterType<BookRepository>().As<IBookRepository>(); //����������� ���������� �����������
            builder.RegisterType<BookService>(); //����������� ������
            var contaiter = builder.Build(); //�������� �������
            DependencyResolver.SetResolver(new AutofacDependencyResolver(contaiter)); //������ ������������ ���������� ����������� �� ���������� AutoFac

            Database.SetInitializer(new MyContextInitializer());
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

        }
    }
}
