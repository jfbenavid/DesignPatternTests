namespace StepPattern
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Step<TResponse> where TResponse : class
    {
        public abstract StepResponse<TResponse> Execute();
    }
}