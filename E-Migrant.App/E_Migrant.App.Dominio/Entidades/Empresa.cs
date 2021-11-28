using System;
using System.ComponentModel.DataAnnotations;

namespace E_Migrant.App.Dominio
{
    public class Empresa
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Razon Social requerido")]
        public string Razon_Social { get; set; }
        
        [Required(ErrorMessage = "Nit requerido")]
        public string Nit { get; set; }

        [Required(ErrorMessage = "Direccion Requerida")]
        public String Direccion { get; set; }

        [Required(ErrorMessage = "Ciudad requerida")]
        public string Ciudad { get; set; }
       
        [Required(ErrorMessage = "Telefono requerida")]
        public String Telefono { get; set; }

        public string Email { get; set; }
        public string Pagina_Web { get; set; }

        [Required(ErrorMessage = "Sector requerido")]
        public Sector Sector { get; set; }

        [Required(ErrorMessage = "Servicios requeridos")]
        public Tipo_Servicios Tipo_Servicios { get; set; }

 }

}