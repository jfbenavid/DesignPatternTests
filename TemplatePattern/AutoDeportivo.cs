namespace TemplatePattern
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AutoDeportivo : Automovil
    {
        public override void Acelerar()
        {
            Console.WriteLine("Arrancando auto deportivo: uso cambios en volante");
        }

        public override void Encender()
        {
            Console.WriteLine("Enciendo auto deportivo acercando la llave");
        }

        public override void Frenar()
        {
            Console.WriteLine("Freno mi auto deportivo automaticamente");
        }
    }
}