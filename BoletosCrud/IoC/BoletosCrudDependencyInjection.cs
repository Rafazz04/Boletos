using BoletosCrud.Context.Repositories;
using BoletosCrud.Context.Repositories.Contracts;
using BoletosCrud.Services;
using BoletosCrud.Services.Contracts;

namespace BoletosCrud.IoC;

public static class BoletosCrudDependencyInjection
{
    public static void AddRepositories(this IServiceCollection services)
    {
        services.AddTransient<IBoletoRepository, BoletoRepository>();
        services.AddTransient<IBancoRepository, BancoRepository>();
    }

    public static void AddServices(this IServiceCollection services)
    {
        services.AddTransient<IBoletoService, BoletoService>();
        services.AddTransient<IBancoService, BancoService>();
    }
}
