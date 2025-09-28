using DataAcessLayer.CRUDoperations;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDataAcessServices(this IServiceCollection services)
        {
          
            services.AddScoped<IUser, User>();


            

            return services;
        }
    }
}
