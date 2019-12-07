 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Shops.Data;
using Shops.Data.Interfaces;
using Shops.Data.Mocks;
using Shops.Data.Models;
using Shops.Data.Repository;
using Shops.Hubs;
using Shops.Services;

namespace Shops
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddDbContext<AppDBContent>(options => options.UseSqlLite(.GetConnectionString("DefaultConnection")));
            services.AddTransient<IAllCars, CarRepository>();
            services.AddTransient<ICarsCategory, CategoryRepository>();
            services.AddTransient<IAllOrders, OrdersRepository>();

            services.AddHttpContextAccessor();
            services.AddScoped(sp => ShopCart.GetCart(sp));

            services.AddDbContext<CarsContext>(options =>
            {
                options.UseSqlite("Filename=cars.db");
            });

            services.AddIdentity<IdentityUser, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 10;
                options.Password.RequiredUniqueChars = 3;
            }).AddEntityFrameworkStores<CarsContext>();
            
            services.AddMvc(options=>options.EnableEndpointRouting = false);

            services.AddMemoryCache();
            services.AddSession();
            services.AddSignalR();
            services.AddRazorPages();

            services.AddScoped<AccountServices>();
            services.AddScoped<ICarsRepo, CarsRepo>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseSession();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapHub<ChatHub>("/chatHub");
            });
            app.UseMvc(routes=>
            {
                routes.MapRoute(name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            using (var scope = app.ApplicationServices.CreateScope())
            {
                CarsContext context = scope.ServiceProvider.GetRequiredService<CarsContext>();
                DBObjects.First(context);
            }

         

        }
    }
}
