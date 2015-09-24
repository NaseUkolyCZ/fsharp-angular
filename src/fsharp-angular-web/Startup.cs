using fsharp_angular_web.Model;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using Microsoft.Framework.DependencyInjection;
using Newtonsoft.Json.Serialization;
using System.Linq;

namespace fsharp_angular_web
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
        }

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
            app.UseDefaultFiles();
            app.UseMvc();
            app.UseStaticFiles();
        }
    }
}