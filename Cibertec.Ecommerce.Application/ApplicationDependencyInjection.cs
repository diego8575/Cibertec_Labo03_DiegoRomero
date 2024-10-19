using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cibertec.Ecommerce.Application
{
    public static class ApplicationDependencyInjection
    {

        public static IServiceCollection AddApplicationDependencies (this IServiceCollection services)
        {
          
            services.AddMediatR(x=> x.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));
            return services;

        }

    }
}
