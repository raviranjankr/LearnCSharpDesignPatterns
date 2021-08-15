using System;
using System.Collections.Generic;
using System.Text;

namespace ChainofResponsibility
{
    // Disburse20 is one of the from different processor classes that will implement the IDisburseChain interface and provide implementation of dispurse methods.
    class Disburse20 : IDisburseChain
    {
        private IDisburseChain disburseChain;
        public void Dispurse(DisburseAmount amount)
        {
            if (amount.getAmount() >= 20)
            {
                int num = amount.getAmount() / 20;
                int remainder = amount.getAmount() % 20;
                Console.WriteLine($"Disbursing Amount {num} 20 Rs Note");
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
