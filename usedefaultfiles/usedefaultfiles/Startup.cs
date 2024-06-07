using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace usedefaultfiles
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
           // services.AddMvcCore(p=>p.EnableEndpointRouting=false);
            services.AddMvc(p => p.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
          //  if (env.IsDevelopment())
          //  {
            //    app.UseDeveloperExceptionPage();
           // }

            //app.UseRouting();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!");
            //    });
            //});


            //by default index html page called from root folder
            //app.UseDefaultFiles();
            //app.UseStaticFiles();


            //by default home page would be displayed for that this code
            //DefaultFilesOptions opt = new DefaultFilesOptions();
            //opt.DefaultFileNames.Clear();
            //opt.DefaultFileNames.Add("homepage.html");
            //app.UseDefaultFiles(opt);
            //app.UseStaticFiles();


            //app.UseDirectoryBrowser();

            //static file use without app.UseStaticFiles(); then we use fileserveroptions.
            //FileServerOptions ftp =new FileServerOptions();
            //ftp.DefaultFilesOptions.DefaultFileNames.Clear();
            //ftp.DefaultFilesOptions.DefaultFileNames.Add("homepage.html");
            //app.UseFileServer(ftp);


            app.UseMvcWithDefaultRoute();
            app.UseMvc(
                p =>
                {
                    p.MapRoute(
                        "default",
                        "{Controller=Home}/{action=sayhello}"
                        );
                }
                );

        }
    }
}
