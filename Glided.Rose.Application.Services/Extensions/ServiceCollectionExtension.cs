using Glided.Rose.Application.Services.Contracts;
using Glided.Rose.Application.Services.Implementations;
using Microsoft.Extensions.DependencyInjection;


namespace Glided.Rose.Application.Services.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IItemService, ItemsService>();
            services.AddScoped<ICalculator, Calculator>();
        }
    }
}
