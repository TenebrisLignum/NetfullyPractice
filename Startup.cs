using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Finances.Domain;
using Finances.Service;
using MyCompany.Service;
using Finances.Domain.Repositories.Abstract;
using Finances.Domain.Repositories.EntityFramework;

namespace Finances
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) => Configuration = configuration;
        public void ConfigureServices(IServiceCollection services)
        {
            //Підключаємо конфіг з appsettings.json
            Configuration.Bind("Project", new Config());

            //Підключаємо необхідний функціонал сайту в якості сервісів
            services.AddTransient<IEntityBaseRepository, EFEntityBaseRepository>();
            services.AddTransient<DataManager>();

            //Підключаємо контекст БД
            services.AddDbContext<AppDbContext>(x => x.UseSqlServer(Config.ConnectionString));

            //Підключаємо систему ідентифікації
            services.AddIdentity<IdentityUser, IdentityRole>(opts =>
            {
                opts.User.RequireUniqueEmail = true;
                opts.Password.RequiredLength = 6;
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireUppercase = false;
                opts.Password.RequireDigit = false;
            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

            //Налаштовуємо файли Cookie для системи ідентифікації
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.Name = "myCompanyAuth";
                options.Cookie.HttpOnly = true;
                options.LoginPath = "/account/login";
                options.AccessDeniedPath = "/account/accessdenied";
                options.SlidingExpiration = true;
            });

            //Налаштовуємо політику авторизації для Admin area
            services.AddAuthorization(x =>
            {
                x.AddPolicy("AdminArea", policy => { policy.RequireRole("admin"); });
            });

            //Підтримка контролерів та представлень (MVC)
            services.AddControllersWithViews(x =>
            {
                x.Conventions.Add(new AdminAreaAuthorization("Admin", "AdminArea"));
            })
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

            //Підключаємо аутентификацію та авторизацію
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization(); 

            // Підтримка статичних файлів (css, js)
            app.UseStaticFiles();

            // Реєстрація потрібних маршрутів
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("admin", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
