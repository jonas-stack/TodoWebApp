using Microsoft.EntityFrameworkCore;
using TodoApp.Api;
using TodoApp.Application;
using TodoApp.Infrastructure;
using TodoApp.Infrastructure.PostgreSQL;

var builder = WebApplication.CreateBuilder(args);

// Compose modules
builder.Services
    .AddApplicationModule()
    .AddInfrastructureModule()
    .AddPostgreSqlModule()
    .AddApiModule();

builder.Logging.AddConsole();

var app = builder.Build();

app.UseRouting();
app.UseApiModule();

app.Run();