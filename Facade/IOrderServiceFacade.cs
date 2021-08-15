using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public interface IOrderServiceFacade
    {
        bool placeOrder(int productId);
    }
}
