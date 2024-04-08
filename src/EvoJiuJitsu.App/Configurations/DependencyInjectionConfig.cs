using EvoJiuJitsu.Business.Interfaces;
using EvoJiuJitsu.Business.Notificacoes;
using EvoJiuJitsu.Business.Services;
using EvoJiuJitsu.Data.Context;
using EvoJiuJitsu.Data.Repository;

namespace EvoJiuJitsu.App.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependecies(this IServiceCollection services)
        {
            services.AddScoped<EvoDbcontext>();
            services.AddScoped<IAtletaRepository, AtletaRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddScoped<IAtletaService, AtletaService>();
            services.AddScoped<INotificador, Notificador>();


            return services;
        }
    }
}
