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

            services.ConfigureCors(
                cors => cors.AddPolicy("AnyOrigin", b => b.AllowAnyOrigin())
            );

            services.Configure<MvcOptions>(
                options => options.Filters.Add(
                    new CorsAuthorizationFilterFactory("AnyOrigin")
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
