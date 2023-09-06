using Application.UnitOfWork;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

namespace ApiIncidencePro.Extensions;
public static class ApplicationServiceExtension
{
    public static void ConfigureCors(this IServiceCollection services) =>
    services.AddCors(options =>
    {
        options.AddPolicy("CorsPolicy", builder =>
            builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
    });
    public static void AddAppplicationServices(this IServiceCollection services)
    {
        //services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        //services.AddScoped<IAreaInterface, AreaRepository>();
        //services.AddScoped<IAreaUser, AreaUserRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
    }
}