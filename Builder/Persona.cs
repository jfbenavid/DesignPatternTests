namespace BuilderPattern
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Persona
    {
        public Persona()
        { }

        public Persona(int edad)
        {
            Edad = edad;
        }

        public Persona(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Nombre { get; set; }
    }
}