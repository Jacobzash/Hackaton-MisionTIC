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
    public class CrearServicioModel : PageModel
    {
        private readonly IRepositorioServicio repositorioServicio;
        private readonly IRepositorioEmpresa repositorioEmpresa;
        public Servicio servicio { get; set; }
        public List<SelectListItem> empresas { get; set; }

        public int Id { get; set; }

        public CrearServicioModel(IRepositorioServicio repositorioServicio, IRepositorioEmpresa repositorioEmpresa)
        {
            this.repositorioServicio = repositorioServicio;
            this.repositorioEmpresa = repositorioEmpresa;
            servicio = new Servicio();
            empresas = repositorioEmpresa.getAllEmpresa().Select(
                c => new SelectListItem
                {
                    Text = c.Razon_Social,
                    Value = Convert.ToString(c.Id)
                }
            ).ToList();
        }
        public void OnGet(int Id)
        {
            servicio = repositorioServicio.getServicio(Id);
        }
        public ActionResult OnPost(Servicio servicio, int Id)
        {
           
            if (ModelState.IsValid)
            {
                try
                {
                    Empresa empresa = repositorioEmpresa.getEmpresa(Id);

                    servicio.Empresa = empresa;
                    repositorioServicio.addServicio(servicio);
                    
                    return RedirectToPage("./ListarServicio");
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
