using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using E_Migrant.App.Persistencia;
using E_Migrant.App.Dominio;

namespace E_Migrant.App.FrontEnd
{
    public class ListarMigranteModel : PageModel
    {
        private readonly IRepositorioMigrante repositorioMigrante;
        public ListarMigranteModel(IRepositorioMigrante repositorioMigrante)
        {
            this.repositorioMigrante = repositorioMigrante;
        }
        public IEnumerable<Migrante>migrantes;
        public void OnGet()
        {
            migrantes=repositorioMigrante.getAllMigrante();
        }
    }
}
