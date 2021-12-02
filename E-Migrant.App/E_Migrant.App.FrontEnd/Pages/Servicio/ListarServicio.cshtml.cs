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
    public class ListarServicioModel : PageModel
    {
         private readonly IRepositorioServicio repositorioServicio;
        public ListarServicioModel(IRepositorioServicio repositorioServicio)
        {
            this.repositorioServicio = repositorioServicio;
        }
        public IEnumerable<Servicio> servicios;
        public void OnGet()
        {
            servicios = repositorioServicio.getAllServicio();
        }
    }
}
