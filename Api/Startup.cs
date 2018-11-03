using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Infra;
using Api.Models;
using GraphiQl;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Api
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

            #region [Services]
            services.AddScoped<ChampionshipMatchesService>();
            services.AddScoped<ChampionshipService>();
            services.AddScoped<LeaderboardGroupInfoService>();
            services.AddScoped<LeaderboardService>();
            services.AddScoped<TeamService>();
            #endregion

            #region [cors]
            services.AddCors();
            #endregion

            services.AddMvc();

            #region [EntityFramework]
            var connection = Configuration.GetSection("SQLConnection:ConnectionString").Value;
            services.AddDbContext<DataContext>(options => options.UseSqlServer(connection));
            #endregion

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseGraphiQl();

            #region [Cors]
            app.UseCors(x =>
            {
                x.AllowAnyHeader();
                x.AllowAnyMethod();
                x.AllowAnyOrigin();
            });
            #endregion

            app.UseMvc();
        }
    }
}
