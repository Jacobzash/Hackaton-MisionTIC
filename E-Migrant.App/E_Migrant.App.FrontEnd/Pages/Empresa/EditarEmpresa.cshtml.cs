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
    public class EditarEmpresaModel : PageModel
    {
 private readonly IRepositorioEmpresa repositorioEmpresa;
        public Empresa empresa { get; set; }
        public EditarEmpresaModel(IRepositorioEmpresa repositorioEmpresa)
        {
            this.repositorioEmpresa = repositorioEmpresa;
        }
        public void OnGet(int Id)
        {
            empresa = repositorioEmpresa.getEmpresa(Id);
        }

        
        public IActionResult OnPost(Empresa empresa)
        {
            if (ModelState.IsValid)
            {
                repositorioEmpresa.editEmpresa(empresa);
                return RedirectToPage ("./ListarEmpresa");
            }
            else
            {
                return Page();
            }

        }


    }
}
