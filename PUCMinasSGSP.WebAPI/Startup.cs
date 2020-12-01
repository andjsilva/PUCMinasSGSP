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
using PUCMinasSGSP.Infra.Data.Context;

namespace PUCMinasSGSP.WebAPI
{
    public class Startup
    {

        IConfiguration Configuration { get; set; }
       
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
            services.AddDbContext<SGSPDbContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:SGSPSQLServer"]));
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
        }
    }
}
