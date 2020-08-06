using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Automovil deportivo = new AutoDeportivo();
            Automovil familiar = new AutoFamiliar();

            deportivo.Testear();
            familiar.Testear();
        }
    }
}