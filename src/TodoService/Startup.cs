using Microsoft.AspNet.Builder;
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
