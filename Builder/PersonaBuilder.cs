namespace BuilderPattern
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PersonaBuilder
    {
        private string _apellido;
        private int _edad;
        private string _nombre;

        public PersonaBuilder Build()
        {
            return new PersonaBuilder();
        }

        public PersonaBuilder SetApellido(string apellido)
        {
            _apellido = apellido;
            return this;
        }

        public PersonaBuilder SetEdad(int edad)
        {
            _edad = edad;
            return this;
        }

        public PersonaBuilder SetNombre(string nombre)
        {
            _nombre = nombre;
            return this;
        }
    }
}