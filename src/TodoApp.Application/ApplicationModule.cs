using Microsoft.Extensions.DependencyInjection;

namespace TodoApp.Application;

public static class ApplicationModule
{
    public static IServiceCollection AddApplicationModule(this IServiceCollection services)
    {
        // register application services (e.g., command/query handlers, domain services)
        // services.AddScoped<ITodoService, TodoService>();
        return services;
    }
}