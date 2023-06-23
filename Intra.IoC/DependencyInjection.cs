using Application.InterfaceApp;
using Application.Services;
using Domain.Interfaces;
using Infra.Data.DataContext;
using Infra.Data.Repositorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Intra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
           IConfiguration configuration)
        {

            //INJECTANDO AS DEPENDECIAS DO PROJECTO - BANDO DE DADOS 
            services.AddDbContext<FicheiroContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("ArquivoContext")));


            //INJECTANDO AS DEPENDECIAS DO PROJECTO - INTERFACES DE DOMINIO E REPOSITORIO 
            services.AddScoped<IFicheiro, FicheiroRepository>();

            //INJECTANDO AS DEPENDECIAS DO PROJECTO - APLICATIONAPP E SERVICES DA APPLICATION
            services.AddScoped<IFicheiroApp, FicheiroService>();

            return services;
        }
    }
}
