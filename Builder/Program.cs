using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Persona myPersona1 = new Persona();
            Persona myPersona2 = new Persona(17);
            Persona myPersona3 = new Persona("Juan", "Perez");

            PersonaBuilder otraPesona = new PersonaBuilder()
                .SetApellido("Gomez")
                .SetNombre("Maria")
                .SetEdad(12)
                .Build();
        }
    }
}