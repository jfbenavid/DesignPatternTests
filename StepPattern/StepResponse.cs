namespace StepPattern
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StepResponse<TResponse> where TResponse : class
    {
        public string ErrorMessage { get; set; }
        public bool IsSuccessfull { get; set; }

        public TResponse Result { get; set; }
    }
}