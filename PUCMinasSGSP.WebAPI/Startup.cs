using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using PUCMinasSGSP.Infra.Data.Context;
using PUCMinasSGSP.Infra.IoC;

namespace PUCMinasSGSP.WebAPI
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }

        public Startup(IHostEnvironment hostEnvironment)
        {
            var builder = new ConfigurationBuilder()
                           .SetBasePath(hostEnvironment.ContentRootPath)
                           .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                           .AddJsonFile($"appsettings.{hostEnvironment.EnvironmentName}.json", optional: true)
                           .AddEnvironmentVariables();
            Configuration = builder.Build();
        }



        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<SGSPContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:SGSPSQLServer"]));
            services.RegisterDependencyInjectionSGSP();
            services.AddSwaggerGen( c => 
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "API - Sistema de Gest?o de Sa?de P?blica (SGSP)", Version = "v1" });
            });
            

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI( c => 
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API - Sistema de Gest?o de Sa?de P?blica (SGSP)");
            });
        }
    }
}
