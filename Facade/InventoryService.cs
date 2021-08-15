using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class InventoryService
    {
        public static bool isAvailable(Product product)
        {
            /*Check Warehouse database for product availability*/
            return true;
        }
    }
}
