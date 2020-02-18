﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Autofac;
using Infrastructure.EntityFramework;

namespace Infrastructure
{
    public static class InfrastructureContainer
    {
        public static void Build(ContainerBuilder containerBuilder)
        {
            var infrastructureAssembly = Assembly.GetExecutingAssembly();
            containerBuilder.RegisterAssemblyTypes(infrastructureAssembly)
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
            containerBuilder.RegisterType<AppDbContext>().InstancePerLifetimeScope();
        }
    }
}
