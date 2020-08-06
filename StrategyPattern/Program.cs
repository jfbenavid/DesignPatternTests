using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var tipoSelccionado = TipoVehiculo.Deportivo;

            //switch (tipoSelccionado)
            //{
            //    case TipoVehiculo.Familiar:
            //        Console.WriteLine("Familiar");
            //        break;

            //    case TipoVehiculo.Deportivo:
            //        Console.WriteLine("Deportivo");
            //        break;

            //    case TipoVehiculo.SUV:
            //        Console.WriteLine("Sub");
            //        break;
            //}

            Contexto.Ejecutar(tipoSelccionado);
        }
    }
}