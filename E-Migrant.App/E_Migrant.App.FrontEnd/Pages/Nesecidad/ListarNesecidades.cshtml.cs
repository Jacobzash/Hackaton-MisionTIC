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
    public class ListarNesecidadesModel : PageModel
    {
        private readonly IRepositorioNesecidad repositorioNesecidad;
        public ListarNesecidadesModel(IRepositorioNesecidad repositorioNesecidad)
        {
            this.repositorioNesecidad = repositorioNesecidad;
        }
        public IEnumerable<Nesecidad> nesecidades;
        public void OnGet()
        {
            nesecidades = repositorioNesecidad.getAllNesecidades();
        }
    }
}

