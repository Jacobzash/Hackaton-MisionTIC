using System;
using System.ComponentModel.DataAnnotations;

namespace E_Migrant.App.Dominio
{
    public class Servicio
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nombre de servicio requerido")]
        public string Nombre_Servicio { get; set; }

        [Required(ErrorMessage = "Numero maximo de migrantes")]
        public int Max_Migrante { get; set; }
        
        [Required(ErrorMessage = "Fecha inicio requerido")]
        public DateTime Fecha_InicioOfer { get; set; }

        [Required(ErrorMessage = "Fecha finalizacion Requerida")]
        public DateTime Fecha_FinalOfer { get; set; }     
       
        [Required(ErrorMessage = "Estado de servicio requerida")]
        public EstadoServicio EstadoServicio { get; set; }        

        [Required(ErrorMessage = "Servicios requeridos")]
        public Categoria_Nesecidades Categoria_Nesecidades { get; set; }

        public Nesecidad Nesecidad { get; set; }

        public Empresa Empresa { get; set; }

        [Required(ErrorMessage = "Habilitar Servicio")]
        public Boolean Habilitar { get; set; }

 }

}