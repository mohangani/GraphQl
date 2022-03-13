using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphiQl;
using GraphQL.Server;
using GraphQL.Types;
using GraphQLPractice.Mutation;
using GraphQLPractice.Query;
using GraphQLPractice.Schema;
using GraphQLPractice.Services;
using GraphQLPractice.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace GraphQLPractice
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSingleton<IMenuService, MenuService>();
            services.AddSingleton<ISubMenuService, SubMenuService>();

            services.AddTransient<MenuType>();
            services.AddTransient<SubMenuType>();
            services.AddTransient<MenuQuery>();
            services.AddTransient<SubMenuQuery>();
            services.AddTransient<RootQuery>();
            services.AddTransient<MenuInputType>();
            services.AddTransient<SubMenuInputType>();
            services.AddTransient<MenuMutation>();
            services.AddTransient<SubMenuMutation>();
            services.AddTransient<RootMutation>();
            services.AddTransient<ISchema,RootSchema>();

            services.AddGraphQL(options=>options.EnableMetrics = false).AddSystemTextJson();
        
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseGraphiQl("/mohan");
            app.UseGraphQL<ISchema>();

            //app.UseHttpsRedirection();

            //app.UseRouting();

            //app.UseAuthorization();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllers();
            //});
        }
    }
}
