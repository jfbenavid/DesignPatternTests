﻿namespace StrategyPattern
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FamiliarStrategy : IEstrategia
    {
        public void Ejecutar()
        {
            Console.WriteLine("Familiar");
        }
    }
}