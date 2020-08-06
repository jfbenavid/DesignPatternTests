namespace StepPattern
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StepManager<TResponse> where TResponse : class
    {
        private Queue<Step<TResponse>> _steps = new Queue<Step<TResponse>>();

        public StepManager<TResponse> AddStep(Step<TResponse> stepToAdd)
        {
            _steps.Enqueue(stepToAdd);
            return this;
        }

        public void Execute()
        {
            foreach (var stepItem in _steps)
            {
                var result = stepItem.Execute();

                if (result.IsSuccessfull)
                {
                    Console.WriteLine(" => ok ");
                }
                else
                {
                    Console.WriteLine($" => error > {stepItem.GetType()}");
                }
            }
        }
    }
}