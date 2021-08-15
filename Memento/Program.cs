using System;

namespace MementoDP
{
    public class Memento
    {
        public int Balance { get; }

        public Memento(int balance)
        {
            Balance = balance;
        }
    }

    public class BankAccount
    {
        private int balance;

        public BankAccount(int balance)
        {
            this.balance = balance;
        }

        public Memento Deposit(int amount)
        {
            balance += amount;
            return new Memento(balance);
        }

        public void Restore(Memento m)
        {
            balance = m.Balance;
        }

        public override string ToString()
        {
            return $"{nameof(balance)}: {balance}";
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount(100);
            var m1 = bankAccount.Deposit(500); 
            var m2 = bankAccount.Deposit(250); 
            Console.WriteLine(bankAccount);

            // restore to m1
            bankAccount.Restore(m1);
            Console.WriteLine(bankAccount);

            bankAccount.Restore(m2);
            Console.WriteLine(bankAccount);

            Console.ReadKey();
        }
    }
}
