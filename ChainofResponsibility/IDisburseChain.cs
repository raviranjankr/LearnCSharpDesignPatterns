using System;
using System.Collections.Generic;
using System.Text;

namespace ChainofResponsibility
{
    // The base interface have a method to define the next processor in the chain and the method that will process the request. 
    public interface IDisburseChain
    {
        void SetNextChain(IDisburseChain nextChain);

        void Dispurse(DisburseAmount amount);
    }
}
