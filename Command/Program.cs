using System;
using System.Collections.Generic;
using System.Linq;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Wallet wallet = new Wallet();           
            Console.WriteLine(wallet);

            while (true)
            {
                Console.WriteLine(@"Select Option.\n1. For Deposit.\n2. For Withdraw");
                int opt = Convert.ToInt32(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        Console.WriteLine("Enter amount for Deposit in Wallet");
                        int deposit = Convert.ToInt32(Console.ReadLine());
                        WalletCommand walletCommandD = new WalletCommand(wallet, WalletCommand.Action.Deposit, deposit);
                        walletCommandD.Call();
                        break;
                    case 2:
                        Console.WriteLine("Enter amount for withdrawl from Wallet");
                        int withdrawl = Convert.ToInt32(Console.ReadLine());
                        WalletCommand walletCommandW = new WalletCommand(wallet, WalletCommand.Action.Withdraw, withdrawl);
                        walletCommandW.Call();
                        break;
                    default:
                        Console.WriteLine("Invalid. option not found !!");
                        break;
                }
            }            
        }
    }
}
