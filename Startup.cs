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
            //ϳ������� ���������� �� ������������ (MVC)
            services.AddControllersWithViews()
                //��������� � ASP.NET Core 3.0
                .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0)
                .AddSessionStateTempDataProvider();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                // ���������� ���������� ��� �������, ���� �� � ����� �������
                app.UseDeveloperExceptionPage();
            }

            // ������� �������������
            app.UseRouting();
            // ϳ������� ��������� ����� (css, js)
            app.UseStaticFiles();
            // ��������� �������� ��������
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
