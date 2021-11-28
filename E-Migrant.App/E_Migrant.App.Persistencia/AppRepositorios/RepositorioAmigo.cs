using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using E_Migrant.App.Dominio;
using E_Migrant.App.Persistencia;

namespace E_Migrant.App.Persistencia
{
    public class RepositorioAmigo : IRepositorioAmigo
    {
        private readonly AppContext _contexto;
        
        public RepositorioAmigo(AppContext contexto)
        {
            this._contexto = contexto;
        }
        public Amigo addAmigo(Amigo amigo)
        {
            Amigo newAmigo = _contexto.Add(amigo).Entity;
            _contexto.SaveChanges();
            return newAmigo;
        }

        public Amigo editAmigo(Amigo amigo)
        {
            Amigo AmigoAEditar = _contexto.Amigos.FirstOrDefault(c=> c.Id == amigo.Id);
            if(AmigoAEditar != null)
            {
                AmigoAEditar.Name= amigo.Name;
                
                AmigoAEditar.AmigoOFamiliar = amigo.AmigoOFamiliar;
                _contexto.SaveChanges();

            }
            return AmigoAEditar;
        }

        public IEnumerable<Amigo> getAllAmigo()
        {
           return _contexto.Amigos;
        }


        public Amigo getAmigo(int Id)
        {
            return _contexto.Amigos.FirstOrDefault(x=> x.Id == Id);
        }

        public void removeAmigo(string Name)
        {
         
            Amigo amigo = _contexto.Amigos.FirstOrDefault(c => c.Name == Name);
            if(amigo != null){
                _contexto.Amigos.Remove(amigo);
                _contexto.SaveChanges();
             }
            
        }

       
    }
}