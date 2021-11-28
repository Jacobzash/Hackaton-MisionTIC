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
    public class CrearEmpresaModel : PageModel
    {
         private IRepositorioEmpresa repositorioEmpresa;
        public Empresa Empresa { get; set; }

        public CrearEmpresaModel(IRepositorioEmpresa repositorioEmpresa)
        {
            this.repositorioEmpresa = repositorioEmpresa;
        }
        public void OnGet()
        {
            Empresa Empresa = new Empresa();
        }
        public IActionResult OnPost(Empresa empresa)
        {
            if (ModelState.IsValid)
            {
                try{
                repositorioEmpresa.addEmpresa(empresa);
                return RedirectToPage("./ListarEmpresa");
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
