namespace TemplatePattern
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Automovil
    {
        public abstract void Acelerar();

        public abstract void Encender();

        public abstract void Frenar();

        public virtual void Testear()
        {
            Encender();
            Acelerar();
            Frenar();
        }
    }
}