using System.Collections.Generic;
using E_Migrant.App.Dominio;

namespace E_Migrant.App.Persistencia
{
    public interface IRepositorioMigrante
    {
        //Consultar todos los Migrantes
        IEnumerable<Migrante> getAllMigrante();
        //Añadir Migrante
        Migrante addMigrante(Migrante Migrante);
        //Editar Migrante
        Migrante editMigrante(Migrante Migrante);
        //Eliminar Migrante
        void removeMigrante(string Numero_Documento);

        Migrante getMigrante(int Id);
    }
}