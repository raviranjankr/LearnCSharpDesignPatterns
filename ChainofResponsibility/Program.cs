using System;

namespace ChainofResponsibility
{
    class Program
    {
        private IDisburseChain disburseChain;

        public Program()
        {
            // initialize the chain
            this.disburseChain = new Disburse50();
            IDisburseChain disburseChain50 = new Disburse50();
            IDisburseChain disburseChain20 = new Disburse20();
            IDisburseChain disburseChain10 = new Disburse10();

            // set the chain of responsibility
            disburseChain.SetNextChain(disburseChain50);
            disburseChain50.SetNextChain(disburseChain20);
            disburseChain20.SetNextChain(disburseChain10);
        }
        static void Main(string[] args)
        {
            Program aTMDisburseChain = new Program();            
            while (true)
            {
                int amount = 0;
                Console.WriteLine("Enter Amount to Disburse");
                amount = Convert.ToInt32(Console.ReadLine());
                if (amount % 10 != 0)
                {
                    Console.WriteLine("Amount should be in multiple of 10s.");
                    return;
                }
                // process the request
                aTMDisburseChain.disburseChain.Dispurse(new DisburseAmount(amount));                
            }
            
        }
    }
}
