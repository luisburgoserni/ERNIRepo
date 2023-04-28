using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.net.core.ejemplo.application.contracts.Services;
using api.net.core.ejemplo.application.Services;
using api.net.core.ejemplo.dataaccess;
using api.net.core.ejemplo.dataaccess.contracts;
using api.net.core.ejemplo.dataaccess.contracts.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace api.net.core.ejemplo
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddSwaggerGen(cfg =>
            {
                cfg.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info
                {
                    Version = "1.0",
                    Title = "Ejemplo api net core curso Udemy"
                });
            });

            services.AddDbContext<BBDDContext>(opt => opt.UseInMemoryDatabase("MiDDBB"));
            //services.AddDbContext<BBDDContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddTransient<IBBDDContext, BBDDContext>();
            services.AddTransient<IModelItemRepository, ModelItemRepository>();
            services.AddTransient<IModelService, ModelService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseSwagger();

            app.UseSwaggerUI(cfg =>
            {
                cfg.SwaggerEndpoint("/swagger/v1/swagger.json", "Ejemplo api net core curso Udemy");
            });


            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
