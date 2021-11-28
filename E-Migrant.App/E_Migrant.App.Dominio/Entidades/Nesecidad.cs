using System;
using System.ComponentModel.DataAnnotations;

namespace E_Migrant.App.Dominio
{
    public class Nesecidad
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nesecidad requerida")]
        public Categoria_Nesecidades Categoria_Nesecidades { get; set; }
        [Required(ErrorMessage = "Descripcion requerida")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "Nivel Requerido")]
        public NivelP NivelP { get; set; }
        public Migrante Migrante { get; set; }
    }


}