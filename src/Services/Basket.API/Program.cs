using Carter;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMediatR(config =>
{
    var assembly = typeof(Program).Assembly;
    config.RegisterServicesFromAssembly(assembly);
});

builder.Services.AddCarter();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapCarter();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Run();
