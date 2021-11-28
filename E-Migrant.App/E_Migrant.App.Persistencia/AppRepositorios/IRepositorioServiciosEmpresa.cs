using System.Collections.Generic;
using E_Migrant.App.Dominio;

namespace E_Migrant.App.Persistencia
{
    public interface IRepositorioServiciosEmpresa
    {
        //Consultar todos las ServiciosEmpresas
        IEnumerable<ServiciosEmpresa> getAllServiciosEmpresa();
        //Añadir ServiciosEmpresa
        ServiciosEmpresa addServiciosEmpresa(ServiciosEmpresa ServiciosEmpresa);
        //Editar ServiciosEmpresa
        ServiciosEmpresa editServiciosEmpresa(ServiciosEmpresa ServiciosEmpresa);
        //Eliminar ServiciosEmpresa
        void removeServiciosEmpresa(string Id);

        ServiciosEmpresa getServiciosEmpresa(int Id);
    }
}