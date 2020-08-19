using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using UserManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using UserManagementSystem.Data;

namespace UserManagementSystem
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
            services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnect")));
            services.AddDbContext<AuthDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("AuthDbContextConnection")));
            
            services.AddRazorPages();
            services.AddControllersWithViews();

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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseAuthentication();

            // Map path route
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "/",
                    pattern: "{controller=Home}/{action=Home}/{id?}"); // default called
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Home}/{id?}"); // default called
                endpoints.MapControllerRoute(
                    name: "login",
                    pattern: "{controller=Login}/{action=Index}/{id?}"); // for login page
                endpoints.MapControllerRoute(
                    name: "register",
                    pattern: "{controller=Register}/{action=Index}/{id?}"); // for register page

                endpoints.MapRazorPages();
            });
        }
    }
}
