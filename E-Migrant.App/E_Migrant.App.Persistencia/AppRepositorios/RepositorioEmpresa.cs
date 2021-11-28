using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using E_Migrant.App.Dominio;
using E_Migrant.App.Persistencia;

namespace E_Migrant.App.Persistencia
{
    public class RepositorioEmpresa : IRepositorioEmpresa
    {
        private readonly AppContext _contexto;
        
        public RepositorioEmpresa(AppContext contexto)
        {
            this._contexto = contexto;
        }
        public Empresa addEmpresa(Empresa empresa)
        {
            Empresa newEmpresa = _contexto.Add(empresa).Entity;
            _contexto.SaveChanges();
            return newEmpresa;
        }

        public Empresa editEmpresa(Empresa empresa)
        {
            Empresa EmpresaAEditar = _contexto.Empresas.FirstOrDefault(c=> c.Id == empresa.Id);
            if(EmpresaAEditar != null)
            {
                EmpresaAEditar.Razon_Social= empresa.Razon_Social;
                EmpresaAEditar.Nit = empresa.Nit;
                EmpresaAEditar.Direccion = empresa.Direccion;
                EmpresaAEditar.Ciudad = empresa.Ciudad;
                EmpresaAEditar.Telefono = empresa.Telefono;
                EmpresaAEditar.Email = empresa.Email;
                EmpresaAEditar.Pagina_Web= empresa.Pagina_Web;
                EmpresaAEditar.Sector= empresa.Sector;
                EmpresaAEditar.Tipo_Servicios= empresa.Tipo_Servicios;
                _contexto.SaveChanges();

            }
            return EmpresaAEditar;
        }

        public IEnumerable<Empresa> getAllEmpresa()
        {
           return _contexto.Empresas;
        }


        public Empresa getEmpresa(int Id)
        {
            return _contexto.Empresas.FirstOrDefault(x=> x.Id == Id);
        }

        public void removeEmpresa(string Nit)
        {
         
            Empresa empresa = _contexto.Empresas.FirstOrDefault(c => c.Nit == Nit);
            if(empresa != null){
                _contexto.Empresas.Remove(empresa);
                _contexto.SaveChanges();
             }
            
        }

       
    }
}