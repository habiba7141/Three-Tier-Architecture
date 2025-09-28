using BusinessLayer.Service;
using DataAcessLayer.CRUDoperations;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {

            services.AddScoped<IManageRegisteration, ManageRegisteration>();




            return services;
        }
    }
}
