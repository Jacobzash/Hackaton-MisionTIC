using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using E_Migrant.App.Dominio;
using E_Migrant.App.Persistencia;

namespace E_Migrant.App.Persistencia
{
    public class RepositorioMigrante : IRepositorioMigrante
    {
        private readonly AppContext _contexto;
        
        public RepositorioMigrante(AppContext contexto)
        {
            this._contexto = contexto;
        }
        public Migrante addMigrante(Migrante migrante)
        {
            Migrante newMigrante = _contexto.Add(migrante).Entity;
            _contexto.SaveChanges();
            return newMigrante;
        }

        public Migrante editMigrante(Migrante migrante)
        {
            Migrante MigranteAEditar = _contexto.Migrantes.FirstOrDefault(c=> c.Id == migrante.Id);
            if(MigranteAEditar != null)
            {
                MigranteAEditar.Nombre= migrante.Nombre;
                MigranteAEditar.Apellidos = migrante.Apellidos;
                MigranteAEditar.Tipo_Documento = migrante.Tipo_Documento;
                MigranteAEditar.Numero_Documento = migrante.Numero_Documento;
                MigranteAEditar.Fecha_nacimiento = migrante.Fecha_nacimiento;
                MigranteAEditar.Email = migrante.Email;
                MigranteAEditar.Telefono= migrante.Telefono;
                MigranteAEditar.Direccion= migrante.Direccion;
                MigranteAEditar.Ciudad= migrante.Ciudad;
                MigranteAEditar.Pais = migrante.Pais;
                MigranteAEditar.Situacion_Laboral = migrante.Situacion_Laboral;
                _contexto.SaveChanges();

            }
            return MigranteAEditar;
        }

        public IEnumerable<Migrante> getAllMigrante()
        {
           return _contexto.Migrantes;
        }


        public Migrante getMigrante(int Id)
        {
            return _contexto.Migrantes.FirstOrDefault(x=> x.Id == Id);
        }

        public void removeMigrante(string Numero_Documento)
        {
         
            Migrante migrante = _contexto.Migrantes.FirstOrDefault(c => c.Numero_Documento == Numero_Documento);
            if(migrante != null){
                _contexto.Migrantes.Remove(migrante);
                _contexto.SaveChanges();
             }
            
        }

       
    }
}