using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MiniShopApp.Business.Abstract;
using MiniShopApp.Business.Concrete;
using MiniShopApp.Data.Abstract;
using MiniShopApp.Data.Concrete.EFCore;
using MiniShopApp.WebUI.EmailServices;
using MiniShopApp.WebUI.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniShopApp.WebUI
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
            //Uygulaman�jn herhangi bir yerinde IProductRepository kullanarak bir nesne
            //olu�turdu�umuzda, sen bunu EfCoreProductRepository t�r�nden olu�tur.
            services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlite("Data Source = MiniShopAppDb"));

            services.AddIdentity<User, IdentityRole>
                ().AddEntityFrameworkStores<ApplicationContext>
                ().AddDefaultTokenProviders();
            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequiredLength = 6;

                //Lockout Kilitliyecek yanl�� girme halinde
                options.Lockout.MaxFailedAccessAttempts = 3;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);//5 dk sonra yeni hak vericek.

                //User
                options.User.RequireUniqueEmail = true; //Ayn� mailden olamaz.

                //SignIn
                options.SignIn.RequireConfirmedEmail = true;
                //options.SignIn.RequireConfirmedAccount = true; // Hesab�n t�m verileri do�ruysa


            });

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/account/login";
                options.LogoutPath = "/account/logout";
                options.AccessDeniedPath = "/account/accessdenied";
                options.SlidingExpiration = true; //Her requestte timespan(20dk) tekrardan ba�lar .
                options.ExpireTimeSpan = TimeSpan.FromMinutes(20);
                options.Cookie = new CookieBuilder()
                {
                    HttpOnly = true,
                    Name ="MiniShopApp.Security.Cookie"
                };
            });
            services.AddScoped<IProductRepository, EfCoreProductRepository>();
            services.AddScoped<ICategoryRepository, EfCoreCategoryRepository>();

            services.AddScoped<IProductService, ProductManager>();
            //Proje boyunca ICategoryService �a�r�ld���nda, CategoryManager'� kullan�n.
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<IEmailSender, SmtpEmailSender>(i => new SmtpEmailSender(
                Configuration["EmailSender:Host"],
                Configuration.GetValue<int>("EmailSender:Port"),
                Configuration.GetValue<bool>("EmailSender:EnableSSL"),
                Configuration["EmailSender:UserName"],
                Configuration["EmailSender:Password"]

                ));

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                SeedDatabase.Seed();  
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

            app.UseEndpoints(endpoints =>
            {
                
                endpoints.MapControllerRoute(
                    name:"adminproductcreate",
                    pattern:"admin/products/create",
                    defaults: new { controller = "Admin", action = "ProductCreate" }
                    );
                endpoints.MapControllerRoute(
                    name: "adminproducts",
                    pattern:"admin/products",
                    defaults: new { controller = "Admin", action = "ProductList" }

                    );
                endpoints.MapControllerRoute(
                   name: "search",
                   pattern: "search",
                   defaults: new { controller = "MiniShop", action = "Search" }
                   );
                endpoints.MapControllerRoute(
                    name:"products",
                    pattern:"products/{category?}",
                    defaults: new {controller="MiniShop", action="List"}
                    );
                endpoints.MapControllerRoute(
                    name: "adminproductedit",
                    pattern: "admin/products/{id?}",
                    defaults: new { controller = "Admin", action = "ProductEdit" }
                    );
                endpoints.MapControllerRoute(
                   name: "productdetails",
                   pattern: "{url}",
                   defaults: new { controller = "MiniShop", action = "Details" }
                   );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
