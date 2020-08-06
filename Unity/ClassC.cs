namespace Unity
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ClassC
    {
        public ClassC(IInterfaceA a, IInterfaceB b)
        {
            A = a;
            B = b;
        }

        public IInterfaceA A { get; }

        public IInterfaceB B { get; }
    }
}