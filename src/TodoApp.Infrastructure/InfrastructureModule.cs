using Microsoft.Extensions.DependencyInjection;
using TodoApp.Application.Ports.Outgoing;
using TodoApp.Infrastructure.Repositories;

namespace TodoApp.Infrastructure;

public static class InfrastructureModule
{
    public static IServiceCollection AddInfrastructureModule(this IServiceCollection services)
    {
        services.AddScoped<ITodoRepository, TodoRepository>();
        return services;
    }
}