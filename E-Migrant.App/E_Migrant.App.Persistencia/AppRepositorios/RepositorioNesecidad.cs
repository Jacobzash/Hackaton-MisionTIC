using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using E_Migrant.App.Dominio;
using E_Migrant.App.Persistencia;

namespace E_Migrant.App.Persistencia
{
    public class RepositorioNesecidad : IRepositorioNesecidad
    {
        private readonly AppContext _contexto;

        public RepositorioNesecidad(AppContext contexto)
        {
            this._contexto = contexto;
        }
        public Nesecidad addNesecidad(Nesecidad Nesecidad)
        {
            Nesecidad nuevaNesecidad = _contexto.Add(Nesecidad).Entity;
            _contexto.SaveChanges();
            return nuevaNesecidad;
        }


        public Nesecidad editNesecidad(Nesecidad Nesecidad)
        {
            Nesecidad NesecidadAEditar = _contexto.Nesecidades.Include("Migrante").FirstOrDefault(f => f.Id == Nesecidad.Id);
            if (NesecidadAEditar != null)
            {
                NesecidadAEditar.Categoria_Nesecidades = Nesecidad.Categoria_Nesecidades;
                NesecidadAEditar.Descripcion = Nesecidad.Descripcion;

                NesecidadAEditar.NivelP = Nesecidad.NivelP;


                _contexto.SaveChanges();
            }
            return NesecidadAEditar;
        }



        public IEnumerable<Nesecidad> getAllNesecidades()
        {
            return _contexto.Nesecidades.Include("Migrante");
        }



        public Nesecidad getNesecidad(int Id)
        {
            Nesecidad Nesecidad = _contexto.Nesecidades.Include("Migrante").FirstOrDefault(x => x.Id == Id);
            return Nesecidad;
        }

        public void removeNesecidad(int Id)
        {
            Nesecidad Nesecidad = _contexto.Nesecidades.FirstOrDefault(x => x.Id == Id);
            if (Nesecidad != null)
            {
                _contexto.Nesecidades.Remove(Nesecidad);
                _contexto.SaveChanges();
            }

        }


    }
}