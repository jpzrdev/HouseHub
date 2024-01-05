using Application.Interfaces.Repositories;
using Infrastructure.Repositories;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            // services.AddScoped<IInventoryRepository, InventoryRepository>();
            return services;
        }
    }
}