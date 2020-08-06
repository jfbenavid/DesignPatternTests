namespace StepPattern
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SacarPaseStep : Step<Sample>
    {
        public override StepResponse<Sample> Execute()
        {
            var result = new StepResponse<Sample>();
            Console.Write("SacandoPase");
            result.IsSuccessfull = true;
            result.Result = new Sample();
            return result;
        }
    }
}