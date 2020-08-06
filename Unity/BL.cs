namespace Unity
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BL
    {
        private IProduct _product;

        public BL(IProduct product)
        {
            _product = product;
        }

        public void Insert()
        {
            _product.InsertData();
        }
    }
}