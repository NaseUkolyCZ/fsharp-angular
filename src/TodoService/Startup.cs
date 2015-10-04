using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using Microsoft.Framework.DependencyInjection;
using Newtonsoft.Json.Serialization;
using TodoService.Model;

namespace TodoService
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddMvc()
                .AddJsonOptions(options =>
                    options.SerializerSettings.ContractResolver =
                        new CamelCasePropertyNamesContractResolver()
                );
            
            services.AddCors();
            services.ConfigureCors(
                cors => cors.AddPolicy("AllowAll", 
                    b => b.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()
                )
            );

            services.Configure<MvcOptions>(
                options => options.Filters.Add(
                    new CorsAuthorizationFilterFactory("AllowAll")
                )
            );

            services
                .AddEntityFramework()
                .AddInMemoryDatabase()
                .AddDbContext<TodoDbContext>(
                    options => options.UseInMemoryDatabase()
                );
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
        }
    }
}
