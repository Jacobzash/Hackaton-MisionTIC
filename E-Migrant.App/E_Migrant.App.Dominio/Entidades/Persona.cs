using System;
using System.ComponentModel.DataAnnotations;

namespace E_Migrant.App.Dominio
{
    public class Persona
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nombre requerido")]
        public string Nombre { get; set; }
        
        [Required(ErrorMessage = "Apellido requerido")]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "Tipo de Documento Requerido")]
        public Tipo_Documento Tipo_Documento { get; set; }

        [Required(ErrorMessage = "Nuemro de documento requerido")]
        public string Numero_Documento { get; set; }
       
        [Required(ErrorMessage = "La fecha de Nacimiento")]
        public DateTime Fecha_nacimiento { get; set; }

        public string Email { get; set; }
        public string Telefono { get; set; }

        public string Direccion { get; set; }

        public string Ciudad { get; set; }
        //public Situacion_Laboral Situacion_Laboral{ get; set;}

        

    }
}