using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    // The Wallet classes act as Receiver that contain some important business logic.They know how to perform all kinds of operations,
    // associated with carrying out arequest. In fact, any class may serve as a Receiver.
    public class Wallet
    {
        private int balance;
        private int overdraftLimit = -500;

        public void Deposit(int amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited amount is : ${amount}, Total Balance is now {balance}");
        }

        public bool Withdraw(int amount)
        {
            if (balance - amount >= overdraftLimit)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew amount is ${amount}, Total Balance is now {balance}");
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"{nameof(balance)}: {balance}";
        }
    }
}
