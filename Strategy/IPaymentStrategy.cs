using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    // The strategy interface declares operations common to all
    // supported versions of some algorithm. 
    public interface IPaymentStrategy
    {
        public void pay(int amount);
    }
}
