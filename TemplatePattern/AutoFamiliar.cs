namespace TemplatePattern
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AutoFamiliar : Automovil
    {
        public override void Acelerar()
        {
            Console.WriteLine("Arrancando auto familiar: es manual");
        }

        public override void Encender()
        {
            Console.WriteLine("Enciendo auto familiar insertando llave");
        }

        public override void Frenar()
        {
            Console.WriteLine("Freno mi auto familiar usando el pedal");
        }
    }
}