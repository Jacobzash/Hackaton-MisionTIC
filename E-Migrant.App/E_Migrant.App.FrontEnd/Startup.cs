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
using E_Migrant.App.Persistencia;

namespace E_Migrant.App.FrontEnd
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
            services.AddRazorPages(
                options =>{
                    options.Conventions.AuthorizeFolder("/Migrante");
                    options.Conventions.AuthorizeFolder("/Empresa");
                    options.Conventions.AuthorizePage("/Index");
                    options.Conventions.AuthorizeFolder("/Nesecidad");
                    options.Conventions.AuthorizeFolder("/ServiciosEmpresa");
                    }
            );
            Persistencia.AppContext _contexto = new Persistencia.AppContext();
            services.AddSingleton<IRepositorioMigrante>(new RepositorioMigrante(_contexto));
            services.AddSingleton<IRepositorioEmpresa>(new RepositorioEmpresa(_contexto));
            services.AddSingleton<IRepositorioAmigo>(new RepositorioAmigo(_contexto));
            services.AddSingleton<IRepositorioNesecidad>(new RepositorioNesecidad(_contexto));
            services.AddSingleton<IRepositorioServiciosEmpresa>(new RepositorioServiciosEmpresa(_contexto));
            
           
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
                app.UseExceptionHandler("/Error");
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
                    name:"default",
                    pattern:"{controller=Conference}/{action=Index}/{id?}"
                );
                endpoints.MapRazorPages();
            });
        }
    }
}
