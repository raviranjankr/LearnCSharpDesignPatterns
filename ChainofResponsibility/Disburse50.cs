using System;
using System.Collections.Generic;
using System.Text;

namespace ChainofResponsibility
{
    // Disburse50 is one of the from different processor classes that will implement the IDisburseChain interface and provide implementation of dispurse methods.
    class Disburse50 : IDisburseChain
    {
        private IDisburseChain disburseChain;
        public void Dispurse(DisburseAmount amount)
        {
            if (amount.getAmount() >= 50)
            {
                int num = amount.getAmount() / 50;
                int remainder = amount.getAmount() % 50;                
                Console.WriteLine($"Disbursing Amount {num} 50 Rs Note");
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
