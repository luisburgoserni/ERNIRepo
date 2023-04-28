var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapPost("/aspnet", () => "Hola comunidad de ASP.NET!!");

app.Run();
