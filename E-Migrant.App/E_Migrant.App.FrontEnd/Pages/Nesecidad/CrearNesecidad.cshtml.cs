using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using E_Migrant.App.Dominio;
using E_Migrant.App.Persistencia;

namespace E_Migrant.App.FrontEnd
{
    public class CrearNesecidadModel : PageModel
    {
        private readonly IRepositorioNesecidad repositorioNesecidad;
        private readonly IRepositorioMigrante repositorioMigrante;
        public Nesecidad nesecidad { get; set; }
        public List<SelectListItem> migrantes { get; set; }

        public int Id { get; set; }

        public CrearNesecidadModel(IRepositorioNesecidad repositorioNesecidad, IRepositorioMigrante repositorioMigrante)
        {
            this.repositorioNesecidad = repositorioNesecidad;
            this.repositorioMigrante = repositorioMigrante;
            nesecidad = new Nesecidad();
            migrantes = repositorioMigrante.getAllMigrante().Select(
                c => new SelectListItem
                {
                    Text = c.Numero_Documento,
                    Value = Convert.ToString(c.Id)
                }
            ).ToList();
        }
        public void OnGet(int Id)
        {
            nesecidad = repositorioNesecidad.getNesecidad(Id);
        }
        public ActionResult OnPost(Nesecidad nesecidad, int Id)
        {
           
            if (ModelState.IsValid)
            {
                try
                {
                    Migrante migrante = repositorioMigrante.getMigrante(Id);

                    nesecidad.Migrante = migrante;
                    repositorioNesecidad.addNesecidad(nesecidad);
                    
                    return RedirectToPage("./ListarNesecidades");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
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
