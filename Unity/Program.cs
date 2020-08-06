namespace Unity
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Unity.Injection;
    using Unity.Lifetime;

    public class Program
    {
        private static void Main(string[] args)
        {
            UnityContainer ioc = new UnityContainer();

            ioc.RegisterType<DL>();
            ioc.RegisterType<BL>();
            ioc.RegisterType<IProduct, DL>();
            var bl = ioc.Resolve<BL>();
            bl.Insert();
            Console.ReadLine();
        }
    }
}