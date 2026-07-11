using Ordering.API;
using Ordering.Application;
using Ordering.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services
    .AddApplicationServices(builder.Configuration)
    .AddInfrastructureServices()
    .AddAPIServices();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
