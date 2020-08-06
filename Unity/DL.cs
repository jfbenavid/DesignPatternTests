namespace Unity
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DL : IProduct
    {
        public string InsertData()
        {
            var val = "Dependency injection injected";
            Console.WriteLine(val);

            return val;
        }
    }
}