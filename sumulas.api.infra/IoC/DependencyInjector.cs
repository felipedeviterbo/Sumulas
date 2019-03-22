using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using sumulas.api.infra.DataAccess;
using sumulas.api.infra.DataAccess.Repositories;
using sumulas.api.application;
using sumulas.api.application.Interfaces;
using sumulas.api.application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace sumulas.api.infra.IoC
{
    public static class DependencyInjector
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<MongoContext>();
            services.AddScoped<ICampeonatosService, CampeonatoService>();
            services.AddScoped<ICampeonatoRepository, CampeonatoRepository>();
            return services;
        }
    }
}
