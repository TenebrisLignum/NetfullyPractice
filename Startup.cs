using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finances
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //Підтримка контролерів та представлень (MVC)
            services.AddControllersWithViews()
                //сумісність з ASP.NET Core 3.0
                .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0)
                .AddSessionStateTempDataProvider();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                // Показувати інформацію про помилки, якщо ми в режимі роробки
                app.UseDeveloperExceptionPage();
            }

            // Система маршрутизації
            app.UseRouting();
            // Підтримка статичних файлів (css, js)
            app.UseStaticFiles();
            // Реєстрація потрібних маршрутів
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
