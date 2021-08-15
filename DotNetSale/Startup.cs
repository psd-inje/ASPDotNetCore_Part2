using DotNetSale.Data;
using DotNetSale.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetNote.Models;
using DotNetSale.Services;

namespace DotNetSale
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
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDatabaseDeveloperPageExceptionFilter();

            //services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<ApplicationDbContext>();
            //services.AddDefaultIdentity<ApplicationUser>().AddDefaultUI(UIFramework.Bootstrap4).AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddControllersWithViews();


            services.Configure<IdentityOptions>(options =>
            {
                //// https://docs.microsoft.com/ko-kr/aspnet/core/security/authentication/identity-configuration?view=aspnetcore-5.0
                // ��ȣ����
                options.Password.RequiredLength = 6;                                // ��ȣ�� �ּ� 6�ڷ�
                options.Password.RequireDigit = true;                               // ���� �ݵ�� ����
                options.Password.RequireLowercase = true;                           // �ҹ��� �ݵ�� ����
                //options.Password.RequireUppercase = true;                           // �빮�ڸ� ���
                options.Password.RequireNonAlphanumeric = true;                     // �����ڰ� �ƴ� ���ڰ� �ʿ�
                //options.Password.RequiredUniqueChars = 1;                           // ������ ���� ��

                // ��� ����
                options.Lockout.MaxFailedAccessAttempts = 5;                        // 5�� �õ� �� ���
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);  // 10�� �� ��� ����

                // ����� ����
                options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = true;                             // �̸��� �ߺ� ����
            });

            services.AddTransient<ICategoryRepository, CategoryRepositoryInMemory>();
            //services.AddSingleton<InfoService>();
            services.AddSingleton<IInfoService, InfoService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
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

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {

                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
