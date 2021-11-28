using System;
using E_Migrant.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace E_Migrant.App.Persistencia 
{
    public class AppContext : DbContext
    {
        
        public DbSet<Migrante> Migrantes { get; set; } 
        
        public DbSet<Persona> Personas { get; set; }

        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Amigo> Amigos { get; set; }

        public DbSet<Nesecidad> Nesecidades { get; set; }

        public DbSet<ServiciosEmpresa> ServiciosEmpresas { get; set; }
      
        protected override void OnConfiguring(DbContextOptionsBuilder options){
            if (!options.IsConfigured){
                options.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = CriollosDevops");

                //options.UseNpgsql("Host=localhost;Database=my_db;Username=my_user;Password=my_pw");
            }
        }    
    }
}