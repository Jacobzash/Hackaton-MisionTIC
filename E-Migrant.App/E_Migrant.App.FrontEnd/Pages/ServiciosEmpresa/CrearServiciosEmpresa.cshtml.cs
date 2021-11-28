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
    public class CrearServiciosEmpresaModel : PageModel
    {
         private IRepositorioServiciosEmpresa repositorioServiciosEmpresa;
        public ServiciosEmpresa ServiciosEmpresa { get; set; }

        public CrearServiciosEmpresaModel(IRepositorioServiciosEmpresa repositorioServiciosEmpresa)
        {
            this.repositorioServiciosEmpresa = repositorioServiciosEmpresa;
        }
        public void OnGet()
        {
            ServiciosEmpresa ServiciosEmpresa = new ServiciosEmpresa();
        }
        public IActionResult OnPost(ServiciosEmpresa serviciosempresa)
        {
            if (ModelState.IsValid)
            {
                try{
                repositorioServiciosEmpresa.addServiciosEmpresa(serviciosempresa);
                return RedirectToPage("./ListarServiciosEmpresa");
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
