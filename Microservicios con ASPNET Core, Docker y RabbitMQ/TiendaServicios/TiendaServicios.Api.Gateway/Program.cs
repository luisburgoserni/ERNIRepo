using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using TiendaServicios.Api.Gateway.MessageHandler;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddControllers();

builder.Services.AddOcelot().AddDelegatingHandler<LibroHandler>();

var configBuilder = new ConfigurationBuilder()
    .AddJsonFile($"ocelot.json")
    .Build();

builder.WebHost.UseConfiguration(configBuilder);

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthentication();

await app.UseOcelot();

app.MapControllers();

app.Run();