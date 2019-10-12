using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;
using StructureMap;
using Tavisca.TMS.Contracts.Interfaces;
using Tavisca.TMS.Contracts.Models.EmployeeModels;
using Tavisca.TMS.Persistence.EmployeeRepositories;
using Tavisca.TMS.Web.Service.EmployeeServices;

namespace Tavisca.TMS.Web
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

            var sqlUsername = Environment.GetEnvironmentVariable("usernamesql", EnvironmentVariableTarget.Machine);
            var sqlPassword = Environment.GetEnvironmentVariable("passwordsql", EnvironmentVariableTarget.Machine);
            var dbName = "tms_db";
            string connectionString = $"server=localhost;port=3306;Database={dbName}; uid={ sqlUsername };pwd= { sqlPassword }; convert zero datetime=True;";
            var conn = new MySqlConnection(connectionString);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddSingleton<IService<Employee>>(new EmployeeService(new EmployeeRepository(conn)));

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

            app.UseHttpsRedirection();
            app.UseMvc();
            
        }
    }
}
