using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Rauf___Any
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
            //services.AddRazorPages();
            //services.AddMvc(option => option.EnableEndpointRouting = false);

            //services.Configure<RazorViewEngineOptions>(o =>
            //{
            //    //options.AreaViewLocationFormats.Clear();
            //    //options.AreaViewLocationFormats.Add("/Areas/{2}/Views/{1}/{0}.cshtml");
            //    //options.AreaViewLocationFormats.Add("/Areas/{2}/Views/Shared/{0}.cshtml");
            //    //options.AreaViewLocationFormats.Add("/Views/Shared/{0}.cshtml");

            //    // {2} is area, {1} is controller,{0} is the action    
            //    o.ViewLocationFormats.Clear();
            //    o.ViewLocationFormats.Add("/Controllers/{1}/Views/{0}" + RazorViewEngine.ViewExtension);
            //    o.ViewLocationFormats.Add("/Controllers/Shared/Views/{0}" + RazorViewEngine.ViewExtension);

            //    // Untested. You could remove this if you don't care about areas.
            //    o.AreaViewLocationFormats.Clear();
            //    o.AreaViewLocationFormats.Add("/Areas/{2}/Controllers/{1}/Views/{0}" + RazorViewEngine.ViewExtension);
            //    o.AreaViewLocationFormats.Add("/Areas/{2}/Controllers/Shared/Views/{0}" + RazorViewEngine.ViewExtension);
            //    o.AreaViewLocationFormats.Add("/Areas/Shared/Views/{0}" + RazorViewEngine.ViewExtension);
            //});
            //services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            //   .AddCookie(options =>
            //   {
            //       options.SlidingExpiration = true;
            //       options.ExpireTimeSpan = TimeSpan.FromMinutes(100);
            //       //options.AccessDeniedPath = $"/Areas/Admi/account/denied";
            //       options.LoginPath = $"/Areas/Admin/Views/Admin/Login";

            //   });
            //services.Configure<RazorViewEngineOptions>(options =>
            //{
            //    options.AreaViewLocationFormats.Clear();
            //    options.AreaViewLocationFormats.Add("/Areas/{2}/Views/{1}/{0}.cshtml");
            //    //options.AreaViewLocationFormats.Add("/MyAreas/{2}/Views/Shared/{0}.cshtml");
            //    //options.AreaViewLocationFormats.Add("/Views/Shared/{0}.cshtml");
            //});

            services.AddMvc(option => option.EnableEndpointRouting = false);
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
            //app.UseCookiePolicy();

            app.UseStaticFiles();

            //app.UseRouting();

            //app.UseAuthorization();
            //app.UseAuthentication();

            //     app.UseEndpoints(endpoints =>
            //     {
            //         endpoints.MapRazorPages();
            ////         endpoints.MapAreaControllerRoute(
            ////"Admin",
            ////"Admin",
            ////"Admin/{controller=Admin}/{action=index}/{id?}");

            //         endpoints.MapAreaControllerRoute(name: "Admin",areaName:"Admin",
            //                pattern: "{area:exists}/{controller}/{action}",
            //                defaults: new { controller = "Admin", action = "Index" });


            //         endpoints.MapControllerRoute(
            //             name: "default",
            //             pattern: "{controller=Admin}/{action=Index}/{id?}");
            //     });
            //app.UseMvc(routes =>
            //{
            //    //    routes.MapRoute("areaRoute", "{area:exists}/{controller=Admin}/{action=Index}/{id?}");

            //    //    routes.MapRoute(
            //    //        name: "default",
            //    //        template: "{controller=Home}/{action=Index}/{id?}");

            //    //       routes.MapRoute(
            //    //name: "Rauf___Any",
            //    //template: "{area:exists}/{controller=Admin}/{action=login}/{id?}");

            //    // add area routes
            //    routes.MapRoute(name: "areaRoute",
            //        template: "{area:exists}/{controller}/{action}",
            //        defaults: new { controller = "Admin", action = "Login" });

            //    routes.MapRoute(
            //       name: "default",
            //       template: "{controller=Admin}/{action=login}/{id?}");
            //});

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                  name: "default",
                  template: "{area=admin}/{controller=Admin}/{action=login}/{id?}");

                //routes.MapRoute(
                //   name: "default",
                //   template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
