using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using E_Migrant.App.Dominio;
using E_Migrant.App.Persistencia;

namespace E_Migrant.App.Persistencia
{
    public class RepositorioServiciosEmpresa : IRepositorioServiciosEmpresa
    {
        private readonly AppContext _contexto;
        
        public RepositorioServiciosEmpresa(AppContext contexto)
        {
            this._contexto = contexto;
        }
        public ServiciosEmpresa addServiciosEmpresa(ServiciosEmpresa serviciosempresa)
        {
            ServiciosEmpresa newServiciosEmpresa = _contexto.Add(serviciosempresa).Entity;
            _contexto.SaveChanges();
            return newServiciosEmpresa;
        }

        public ServiciosEmpresa editServiciosEmpresa(ServiciosEmpresa serviciosempresa)
        {
            ServiciosEmpresa ServiciosEmpresaAEditar = _contexto.ServiciosEmpresas.FirstOrDefault(c=> c.Id == serviciosempresa.Id);
            if(ServiciosEmpresaAEditar != null)
            {
                ServiciosEmpresaAEditar.NombreServicio= serviciosempresa.NombreServicio;
                ServiciosEmpresaAEditar.MaxMigrantes = serviciosempresa.MaxMigrantes;
                ServiciosEmpresaAEditar.FechaInicioOferta = serviciosempresa.FechaInicioOferta;
                ServiciosEmpresaAEditar.FechaFinalizacionOferta = serviciosempresa.FechaFinalizacionOferta;
                ServiciosEmpresaAEditar.EstadoServicio = serviciosempresa.EstadoServicio;
                ServiciosEmpresaAEditar.CategoriasNecesidades = serviciosempresa.CategoriasNecesidades;
                
                _contexto.SaveChanges();

            }
            return ServiciosEmpresaAEditar;
        }

        public IEnumerable<ServiciosEmpresa> getAllServiciosEmpresa()
        {
           return _contexto.ServiciosEmpresas;
        }


        public ServiciosEmpresa getServiciosEmpresa(int Id)
        {
            return _contexto.ServiciosEmpresas.FirstOrDefault(x=> x.Id == Id);
        }

        public void removeServiciosEmpresa(int Id)
        {
         
            ServiciosEmpresa serviciosempresa = _contexto.ServiciosEmpresas.FirstOrDefault(c => c.Id == Id);
            if(serviciosempresa != null){
                _contexto.ServiciosEmpresas.Remove(serviciosempresa);
                _contexto.SaveChanges();
             }
            
        }

       
    }
}