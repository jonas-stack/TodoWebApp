using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TodoApp.Infrastructure.PostgreSQL;

public static class PostgreSqlModule
{
    public static IServiceCollection AddPostgreSqlModule(this IServiceCollection services)
    {
        // When your DbContext exists, uncomment and configure:
        // services.AddDbContext<TodoDbContext>(opts => opts.UseNpgsql(cs));

        return services;
    }
}