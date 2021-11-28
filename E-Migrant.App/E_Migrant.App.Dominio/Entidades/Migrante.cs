using System;
using System.ComponentModel.DataAnnotations;

namespace E_Migrant.App.Dominio
{
public class Migrante:Persona{ 
    [Required(ErrorMessage = "Pais requerido")]
    public Pais Pais { get; set; }

    public Situacion_Laboral Situacion_Laboral { get; set; }
}


}