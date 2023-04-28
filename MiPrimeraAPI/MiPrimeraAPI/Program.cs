using MiPrimeraAPI.DataAccess;
using Microsoft.EntityFrameworkCore;
using MiPrimeraAPI.Repository;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddDbContext<BBDDContext>(options => options.UseInMemoryDatabase("MiPrimeraAPIDB"));
        //builder.Services.AddDbContext<BBDDContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
        
        builder.Services.AddTransient<IModelItemRepository, ModelItemRepository>();
        builder.Services.AddTransient<IBBDDContext, BBDDContext>();

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}