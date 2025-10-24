using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using TodoApp.Api.GraphQl.Queries;

namespace TodoApp.Api;

public static class ApiModule
{
    public static IServiceCollection AddApiModule(this IServiceCollection services)
    {
        // register GraphQL server and the app's query types
        services.AddGraphQLServer()
            .AddQueryType<TodoQuery>();

        // register other API-layer services here (DTO mappers, controllers, etc.)
        return services;
    }

    public static WebApplication UseApiModule(this WebApplication app)
    {
        // map GraphQL endpoint
        app.MapGraphQL();
        return app;
    }
}