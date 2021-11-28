using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using E_Migrant.App.Dominio;
using E_Migrant.App.Persistencia;

namespace E_Migrant.App.FrontEnd
{
    public class CrearMigranteModel : PageModel
    {
        private IRepositorioMigrante repositorioMigrante;
        public Migrante migrante { get; set; }

        public CrearMigranteModel(IRepositorioMigrante repositorioMigrante)
        {
            this.repositorioMigrante = repositorioMigrante;
        }
        public void OnGet()
        {
            Migrante migrante = new Migrante();
        }
        public IActionResult OnPost(Migrante migrante)
        {
            if (ModelState.IsValid)
            {
                try{
                repositorioMigrante.addMigrante(migrante);
                return RedirectToPage("./ListarMigrante");
                }
                catch{
                    return RedirectToPage("../Error");
                }
            }
            else
            {
                return Page();
            }

        }

    }
}
