namespace StrategyPattern
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class Contexto
    {
        private static readonly Dictionary<TipoVehiculo, IEstrategia> strategies = new Dictionary<TipoVehiculo, IEstrategia>
        {
            {TipoVehiculo.Deportivo, new DeportivoStrategy() },
            {TipoVehiculo.Familiar, new FamiliarStrategy() },
            {TipoVehiculo.SUV, new SuvStrategy() }
        };

        public static void Ejecutar(TipoVehiculo tipo) => strategies[tipo].Ejecutar();
    }
}