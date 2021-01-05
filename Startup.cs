using fantazijos_lyga.Data;
using fantazijos_lyga.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fantazijos_lyga
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
            services.AddDbContextPool<DatabaseContext>(
                dbContextOptions => dbContextOptions
                    .UseMySql(
                        Configuration.GetConnectionString("CentralDatabase"),
                        new MySqlServerVersion(Version.Parse("10.5")),
                        mySqlOptions => mySqlOptions
                            .CharSetBehavior(CharSetBehavior.NeverAppend))
            );
            services.AddRazorPages(options =>
            {
                options.Conventions.AuthorizePage("/AdminPanel");
                options.Conventions.AuthorizePage("/MatchPage");
                options.Conventions.AuthorizePage("/APPlayers");
                options.Conventions.AuthorizePage("/AddTeam");
                options.Conventions.AuthorizePage("/AddStatistics");
                options.Conventions.AuthorizePage("/AddPlayerStatistics");
                options.Conventions.AuthorizePage("/APTeams");
                options.Conventions.AuthorizePage("/APMatch");
            });
            services.AddScoped<IFantasyRepository, FantasyRepository>();

            services.AddHttpContextAccessor();
            services.AddTransient<IActionContextAccessor, ActionContextAccessor>();
            services.AddScoped<IRazorRenderService, RazorRenderService>();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(options => options.LoginPath = "/login");
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseCookiePolicy(new CookiePolicyOptions
            {
                MinimumSameSitePolicy = SameSiteMode.Strict,
            });

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
