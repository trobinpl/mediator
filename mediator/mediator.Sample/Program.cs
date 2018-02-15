using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace mediator.Sample
{
    class Program
    {
        private static IContainer Container { get; set; }

        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Mediator>()
                .As<IMediator>()
                .InstancePerLifetimeScope();

            builder.RegisterType<AutofacHandlerProvider>()
                .As<IHandlerProvider>()
                .InstancePerLifetimeScope();

            // Scan an assembly for components
            builder.RegisterAssemblyTypes(Assembly.Load("mediator.Sample")).AsClosedTypesOf(typeof(IQueryHandler<,>));

            builder.RegisterAssemblyTypes(Assembly.Load("mediator.Sample"))
                .Where(t => t.BaseType == typeof(IQuery<>))
                .AsImplementedInterfaces();

            Container = builder.Build();

            Application app = new Application(Container.Resolve<IMediator>());
            app.Run();
        }
    }
}
