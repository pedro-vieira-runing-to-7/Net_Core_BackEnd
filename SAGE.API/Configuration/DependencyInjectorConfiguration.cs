using SAGE.Cross.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SAGE.Service.Configuration
{
    public static class DependencyInjectorConfiguration
    {
        public static void RegisterDependencInjector(this IServiceCollection services)
        {
            DependencyInjectRegistration.Register(services);
        }
    }
}
