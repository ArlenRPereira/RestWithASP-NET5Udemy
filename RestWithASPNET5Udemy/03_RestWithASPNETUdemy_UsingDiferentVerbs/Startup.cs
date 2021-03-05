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
using _03_RestWithASPNETUdemy_UsingDiferentVerbs.Business;
using _03_RestWithASPNETUdemy_UsingDiferentVerbs.Business.Implementations;
using _03_RestWithASPNETUdemy_UsingDiferentVerbs.Repository;
using _03_RestWithASPNETUdemy_UsingDiferentVerbs.Repository.Implementations;
using _03_RestWithASPNETUdemy_UsingDiferentVerbs.Model.Context;
using MySql.EntityFrameworkCore.Extensions;

namespace _03_RestWithASPNETUdemy_UsingDiferentVerbs
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

            services.AddControllers();

            var connection = Configuration["MySQLConnection:MySQLConnectionString"];
            services.AddDbContext<MySQLContext>(options => options.UseMySQL(connection));

            // Versioning API
            services.AddApiVersioning();

            // Dependency Injection
            services.AddScoped<IPersonBusiness, PersonBusinessImplementation>();
            services.AddScoped<IPersonRepository, PersonRepositoryImplementation>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "_03_RestWithASPNETUdemy_UsingDiferentVerbs", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "_03_RestWithASPNETUdemy_UsingDiferentVerbs v1"));
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
