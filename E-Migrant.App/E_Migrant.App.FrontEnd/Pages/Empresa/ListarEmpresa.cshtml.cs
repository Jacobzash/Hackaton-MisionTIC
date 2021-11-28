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
    public class ListarEmpresaModel : PageModel
    {
        private readonly IRepositorioEmpresa repositorioEmpresa;
        public ListarEmpresaModel(IRepositorioEmpresa repositorioEmpresa)
        {
            this.repositorioEmpresa = repositorioEmpresa;
        }
        public IEnumerable<Empresa>empresas;
        public void OnGet()
        {
            empresas=repositorioEmpresa.getAllEmpresa();
        }
    }
}
