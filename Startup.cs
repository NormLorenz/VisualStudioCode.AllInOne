using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.Framework.DependencyInjection;
using Microsoft.Framework.ConfigurationModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using VisualStudioCode.WebAPI.Models;

namespace VisualStudioCode.WebAPI
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }

        public Startup(IHostingEnvironment env)
        {
            System.Console.WriteLine("...Startup method called");

            // Setup configuration sources
            //  Configuration = new Configuration()
            //      .AddJsonFile("config.json")
            //      .AddEnvironmentVariables();
        }

        // This method gets called by a runtime.
        // Use this method to add services to the container
        public void ConfigureServices(IServiceCollection services)
        {
            System.Console.WriteLine("...ConfigureServices method called");

            // add EF services to the services container.
            services.AddEntityFramework()
                .AddSqlServer()
                .AddDbContext<SalesDbContext>();

            // add Mvc and camel case output
            services.AddMvc().Configure<MvcOptions>(options =>
            {
                int position = options.OutputFormatters.FindIndex(f => f.Instance is JsonOutputFormatter);
                var settings = new JsonSerializerSettings()
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                };

                var formatter = new JsonOutputFormatter();
                formatter.SerializerSettings = settings;
                options.OutputFormatters.Insert(position, formatter);
            });
        }

        // Configure is called after ConfigureServices is called.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            System.Console.WriteLine("...Configure method called");
            
             // Initialize sample data
            //SampleData.InitializeSalesDBDatabaseAsync(app.ApplicationServices).Wait();

            // Configure the HTTP request pipeline.
            app.UseStaticFiles();

            // Add MVC to the request pipeline.
            app.UseMvc(routes =>  
            {
               routes.MapRoute (
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            // show a startup screen for un-mapped routes
            app.UseWelcomePage();
            
        }
    }
}
