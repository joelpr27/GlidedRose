using Glided.Rose.Infrastructure.Repositories.Contracts;
using Glided.Rose.Infrastructure.Repositories.Implementations;
using Microsoft.Extensions.DependencyInjection;


namespace Glided.Rose.Infrastructure.Repositories.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static void AddRepositoriesLayer(this IServiceCollection services)
        {
            services.AddScoped<IJsonReader, JsonReader>();
            services.AddScoped<IItemCreator, ItemCreator>();

        }
    }
}
