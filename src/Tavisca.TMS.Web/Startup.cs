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
using StructureMap;
using AutoMapper;
using Tavisca.TMS.Ioc.StructureMapRegistries;

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
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            var container = new Container();
            container.Configure(config => {
                config.AddRegistry(new EmployeeRegistry());
                config.AddRegistry(new TeamRegistry());
                config.AddRegistry(new SessionRegistry());
                config.AddRegistry(new ScheduleRegistry());
                config.AddRegistry(new TopicRegistry());
                config.AddRegistry(new BatchRegistry());
                config.AddRegistry(new SubTopicRegistry());
                config.AddRegistry(new TrainingRegistry());
                config.Populate(services);
             });
            //container.Populate(services);
            return container.GetInstance<IServiceProvider>();
        }

        public void ConfigureContainer(Registry registry)
        {
           
            // Use StructureMap-specific APIs to register services in the registry.
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
