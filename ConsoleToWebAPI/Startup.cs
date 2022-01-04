using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ConsoleToWebAPI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseEndpoints(endPoints =>
            {
                //endPoints.MapGet("/", async context => {
                //    await context.Response.WriteAsync("Hello From ASP.NET Core Web API");
                //});

                //endPoints.MapGet("/Resource1", async context => {
                //    await context.Response.WriteAsync("Hello From ASP.NET Core Web API Resource1");
                //});
                endPoints.MapControllers();
            });
        }
    }
}
