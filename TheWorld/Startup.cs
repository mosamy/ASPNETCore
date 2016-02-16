using System;
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
            services.AddMvcCore();
            //services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
          
            //this line must come first, ORDER is important
            //app.UseDefaultFiles(); 
            //if this line was first the static page would not be served automatically
            
            app.UseStaticFiles();
              // we are defining a chain of middleware here that will be called back.            app.UseStaticFiles();f middleware here that will be called back.
           /* app.UseMvc(routes =>  
                {
                     routes.MapRoute(
                     name: "default",
                     template: "{controller}/{action}/{id?}",
                     defaults: new {controller = "App" , action = "Index"}
                     );
                }); */
               
               app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=App}/{action=Index}/{id?}");
            });
                
                
                
// 
//             app.Run(async (context) =>
//             {
//                 var html = @"<html><body><h1>The World</h1></body> </html>";
//                 string s =context.Request.Path;
//                 await context.Response.WriteAsync(html);
//             });
        }

        // Entry point for the application.
        public static void Main(string[] args) => Microsoft.AspNet.Hosting.WebApplication.Run<Startup>(args);
    }
}
