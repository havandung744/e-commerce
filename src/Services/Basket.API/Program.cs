using Carter;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMediatR(config =>
{
    var assembly = typeof(Program).Assembly;
    config.RegisterServicesFromAssembly(assembly);
});

builder.Services.AddCarter();

var app = builder.Build();

app.MapCarter();

app.Run();
