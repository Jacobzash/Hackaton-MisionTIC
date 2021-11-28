using System.Collections.Generic;
using E_Migrant.App.Dominio;

namespace E_Migrant.App.Persistencia
{
    public interface IRepositorioNesecidad
    {
        //Consultar todos los Amigos
        IEnumerable<Nesecidad> getAllNesecidades();
        //Añadir Nesecidad
        Nesecidad addNesecidad(Nesecidad Nesecidad);
        //Editar Nesecidad
        Nesecidad editNesecidad(Nesecidad Nesecidad);
        //Eliminar Nesecidad
        void removeNesecidad(int Id);

        Nesecidad getNesecidad(int Id);
    }
}