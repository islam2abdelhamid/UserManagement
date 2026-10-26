using Microsoft.Extensions.DependencyInjection;
using UserManagement.Application.Abstraction.Services;
using UserManagement.Application.Services;

namespace UserManagement.Application.Dependency;

public static class ServiceContainer
{
    public static void AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IOrderService, OrderService>();
    }
}
