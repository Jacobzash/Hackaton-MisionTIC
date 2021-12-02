using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using E_Migrant.App.Dominio;
using E_Migrant.App.Persistencia;

namespace E_Migrant.App.Persistencia
{
    public class RepositorioServicio : IRepositorioServicio
    {
        private readonly AppContext _contexto;
        
        public RepositorioServicio(AppContext contexto)
        {
            this._contexto = contexto;
        }
        public Servicio addServicio(Servicio servicio)
        {
            Servicio newServicio = _contexto.Add(servicio).Entity;
            _contexto.SaveChanges();
            return newServicio;
        }

        public Servicio editServicio(Servicio servicio)
        {
            Servicio ServicioAEditar = _contexto.Servicios.Include("Empresa").FirstOrDefault(c=> c.Id == servicio.Id);
            if(ServicioAEditar != null)
            {
                ServicioAEditar.Nombre_Servicio= servicio.Nombre_Servicio;
                ServicioAEditar.Max_Migrante = servicio.Max_Migrante;
                ServicioAEditar.Fecha_InicioOfer = servicio.Fecha_InicioOfer;
                ServicioAEditar.Fecha_FinalOfer = servicio.Fecha_FinalOfer;
                ServicioAEditar.EstadoServicio = servicio.EstadoServicio;
                ServicioAEditar.Categoria_Nesecidades = servicio.Categoria_Nesecidades;
                ServicioAEditar.Empresa = servicio.Empresa;
                ServicioAEditar.Habilitar = servicio.Habilitar;
                
                _contexto.SaveChanges();

            }
            return ServicioAEditar;
        }

        public IEnumerable<Servicio> getAllServicio()
        {
           return _contexto.Servicios.Include("Empresa");
        }


        public Servicio getServicio(int Id)
        {
            Servicio Servicio = _contexto.Servicios.Include("Empresa").FirstOrDefault(x => x.Id == Id);
            return Servicio;
        }

        public void removeServicio(string Nombre_Servicio)
        {
         
            Servicio servicio = _contexto.Servicios.FirstOrDefault(c => c.Nombre_Servicio == Nombre_Servicio);
            if(servicio != null){
                _contexto.Servicios.Remove(servicio);
                _contexto.SaveChanges();
             }
            
        }

       
    }
}
       