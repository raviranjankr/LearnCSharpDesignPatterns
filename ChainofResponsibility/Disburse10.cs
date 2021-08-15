using System;
using System.Collections.Generic;
using System.Text;

namespace ChainofResponsibility
{
    // Disburse10 is one of the from different processor classes that will implement the IDisburseChain interface and provide implementation of dispurse methods.
    class Disburse10 :IDisburseChain
    {
        private IDisburseChain disburseChain;
        public void Dispurse(DisburseAmount amount)
        {
            // every implementation is trying to process the request and based on the amount, it might process some or full part of it.
            // If one of the chain not able to process it fully, it sends the request to the next processor in chain to process the remaining request.
            if (amount.getAmount() >= 10)
            {
                int num = amount.getAmount() / 10;
                int remainder = amount.getAmount() % 10;
                Console.WriteLine($"Disbursing Amount {num} 10 Rs Note");
                if (remainder != 0) this.disburseChain.Dispurse(new DisburseAmount(remainder));
            }
            else
            {

                this.disburseChain.Dispurse(amount);
            }
        }
        public void SetNextChain(IDisburseChain nextChain)
        {
            this.disburseChain = nextChain;
        }
    }
}
