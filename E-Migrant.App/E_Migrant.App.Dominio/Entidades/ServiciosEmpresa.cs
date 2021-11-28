using System;
using System.ComponentModel.DataAnnotations;

namespace E_Migrant.App.Dominio
{
    public class ServiciosEmpresa
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Nombre Servicio  requerido")]
        public string NombreServicio  { get; set; }
        
        [Required(ErrorMessage = "Máximo número de migrantes requerido")]
        public int MaxMigrantes { get; set; }

        [Required(ErrorMessage = "Fecha de inicio oferta Requerida")]
        public DateTime FechaInicioOferta { get; set; }

        [Required(ErrorMessage = "Fecha finalizacion de oferta requerida")]
        public DateTime FechaFinalizacionOferta { get; set; }
       
        [Required(ErrorMessage = "Estado de Servicio requerida")]
        public EstadoServicio EstadoServicio { get; set; }

        [Required(ErrorMessage = "Categorias requeridas")]
        public CategoriasNecesidades CategoriasNecesidades { get; set; }


 }

}