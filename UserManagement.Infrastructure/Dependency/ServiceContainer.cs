using Microsoft.Extensions.DependencyInjection;
using UserManagement.Application.Abstraction.Repositories;
using UserManagement.Application.Abstraction.Services;
using UserManagement.Infrastructure.Repositories;
using UserManagement.Infrastructure.Services;

namespace UserManagement.Infrastructure.Dependency;
public static class ServiceContainer
{
    public static void AddInfraServices(this IServiceCollection services)
    {
        services.AddScoped<IOrderService, OrderService>();
        services.AddScoped<IOrderRepository, OrderRepository>();
    }
}