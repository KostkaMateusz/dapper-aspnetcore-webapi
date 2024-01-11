using DapperASPNetCore.Context;
using DapperASPNetCore.Contracts;
using DapperASPNetCore.Repository;

namespace DapperASPNetCore;

public static class StartUpHelpersExtensions
{
    public static IServiceCollection ConfigureServices(this IServiceCollection services)
    {
        services.AddSingleton<DapperContext>();
        services.AddScoped<ICompanyRepository, CompanyRepository>();
        services.AddControllers();

        return services;
    }

}