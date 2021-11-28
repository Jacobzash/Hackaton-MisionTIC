using System.Collections.Generic;
using E_Migrant.App.Dominio;

namespace E_Migrant.App.Persistencia
{
    public interface IRepositorioEmpresa
    {
        //Consultar todos las Empresas
        IEnumerable<Empresa> getAllEmpresa();
        //Añadir Empresa
        Empresa addEmpresa(Empresa Empresa);
        //Editar Empresa
        Empresa editEmpresa(Empresa Empresa);
        //Eliminar Empresa
        void removeEmpresa(string Nit);

        Empresa getEmpresa(int Id);
    }
}