using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class Product
    {
        public int productId;
        public String name;
        public Product() { }
        public Product(int productId, String name)
        {
            this.productId = productId;
            this.name = name;
        }
    }
}
