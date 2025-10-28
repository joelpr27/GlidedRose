using Glided.Rose.Application.Contracts;
using Glided.Rose.Application.Services.Implementations;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glided.Rose.Application.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IPassDays, PassDays>();

        }
    }
}
