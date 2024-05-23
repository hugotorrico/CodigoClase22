using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Persona
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Ciudad { get; set; }
    }

    public static class PersonaData
    {
    
        public static List<Persona> GetPersonas()
        {
            var result= new List<Persona>();
            for (int i = 0; i < 2000000; i++)
            {
                result.Add(new Persona { Apellidos = "Apellidos "+ i, Nombres = "Nombres " + i, Ciudad = "Ciudad " + i });
            }
         return result;
        }
    
    
    }
}
