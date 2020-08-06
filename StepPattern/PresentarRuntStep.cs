namespace StepPattern
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PresentarRuntStep : Step<Sample>
    {
        public override StepResponse<Sample> Execute()
        {
            var result = new StepResponse<Sample>();
            Console.Write("Haciendo runt");
            result.IsSuccessfull = false;
            result.Result = new Sample();
            return result;
        }
    }
}