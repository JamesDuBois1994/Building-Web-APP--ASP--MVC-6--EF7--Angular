﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.Extensions.DependencyInjection;

namespace TheWorld
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // Use IIS configue manager, helps for deploying on IIS, great for a wub
        public void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles();

            // Turn on MVC
            app.UseMvc(config =>
            {
                config.MapRoute(name: "Default",
                    // when a request comes in it tries to do a pattern match - template is the name of the controller which is app, action which is index and an optional id           
                    template: "{controller}/{action}/{id?}",
                    defaults: new {controller = "App", action = "Index"}

                    );
            });
        }

        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
