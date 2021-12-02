using System.Collections.Generic;
using E_Migrant.App.Dominio;

namespace E_Migrant.App.Persistencia
{
    public interface IRepositorioServicio
    { 
        //Consultar todos los Servicios
        IEnumerable<Servicio> getAllServicio();
        //Añadir Servicio
        Servicio addServicio(Servicio Servicio);
        //Editar Servicio
        Servicio editServicio(Servicio Servicio);
        //Eliminar Servicio
        void removeServicio(string Nit);

        Servicio getServicio(int Id);


    }

}