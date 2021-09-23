using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetWebApplication
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
            services.AddRazorPages();
            
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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });

            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=HomeController}/{action=Index}/{id?}");
                
                endpoints.MapControllerRoute("Product", "{controller=ProductPageController}/{action=Index}/{id?}");
               
                endpoints.MapControllerRoute("AdministretorPage", "{controller=AdministretorHomePageController}/{action=Index}/{id?}");
                
                endpoints.MapControllerRoute("Bascet", "{controller=BascetController}/{action=Index}");
               
                endpoints.MapControllerRoute("Catalog", "{controller=CatalogPageController}/{action=Index}/{id?}");
               
                endpoints.MapControllerRoute("Contacts", "{controller=ContactsPageController}/{action=Index}/{id?}");
               
                endpoints.MapControllerRoute("CreateProduct", "{controller=CreateProductPageController}/{action=Index}");
              
                endpoints.MapControllerRoute("DecoratedOrders", "{controller=DecoratedOrdersPageController}/{action=Index}");
               
                endpoints.MapControllerRoute("Editors", "{controller=EditorsPageController}/{action=Index}/{id?}");
               
                endpoints.MapControllerRoute("SingUp", "{controller=SingUpPageController}/{action=Index}");
                
                endpoints.MapControllerRoute("Statistics", "{controller=StatisticsPageController}/{action=Index}/{id?}");

            });



        }
    }
}
