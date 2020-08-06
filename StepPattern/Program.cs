using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var paseFlow = new StepManager<Sample>()
                .AddStep(new HacerCursoStep())
                .AddStep(new PresentarRuntStep())
                .AddStep(new SacarPaseStep());

            paseFlow.Execute();

            Console.ReadKey();
        }
    }
}