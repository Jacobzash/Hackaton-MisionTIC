using System;

namespace E_Migrant.App.Dominio
{
    public class Amigo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  Migrante Migrante { get; set; }
        public AmigoOFamiliar AmigoOFamiliar { get; set; }
        
    }

}