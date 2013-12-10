using System.Data.Entity;
using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using CocoFarm.DataAccess;

namespace CocoFarm
{
    public class DependencyConfig
    {
        public static IDependencyResolver GetDepenencyResolver()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            RegisterServices(builder);

            IContainer container = builder.Build();
            return new AutofacDependencyResolver(container);
        }

        private static ContainerBuilder RegisterServices(ContainerBuilder builder)
        {
            builder.RegisterType<CocoFarmContext>().As<DbContext>();

            builder.RegisterGeneric(typeof(DbContextDataStore<>)).As(typeof(IDataStore<,>));
            return builder;
        }

    }
}