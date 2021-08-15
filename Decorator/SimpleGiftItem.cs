using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    // SimpleGiftItem is a Concrete Components that provide default implementations of the operations.    
    class SimpleGiftItem : IGiftComponent
    {
        public double GetCost()
        {
            return 5;
        }
        public string PackGiftItem()
        {
            return "Putting in the Box";
        }
    }
}
