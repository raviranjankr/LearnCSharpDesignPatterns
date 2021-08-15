using System;
using System.Collections.Generic;
using System.Text;

namespace ChainofResponsibility
{
    // DisburseAmount class will store the amount to disburse and used by the chain implementations.
    public class DisburseAmount
    {
        private int amount { get; set; }

        public DisburseAmount(int amt)
        {
            this.amount = amt;
        }

        public int getAmount()
        {
            return this.amount;
        }
    }
}
