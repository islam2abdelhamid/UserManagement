using Microsoft.Extensions.DependencyInjection;
using UserManagement.Application.Abstraction.Repositories;
using UserManagement.Infrastructure.Repositories;

namespace UserManagement.Infrastructure.Dependency;

public static class ServiceContainer
{
    public static void AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddScoped<IOrderRepository, OrderRepository>();
    }
}
