using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class WalletCommand
    {
        private Wallet wallet;

        public enum Action
        {
            Deposit, Withdraw
        }

        private Action action;
        private int amount;
        private bool succeeded;

        public WalletCommand(Wallet wallet, Action action, int amount)
        {
            this.wallet = wallet ?? throw new ArgumentNullException(paramName: nameof(wallet));
            this.action = action;
            this.amount = amount;
        }

        public void Call()
        {
            switch (action)
            {
                case Action.Deposit:
                    wallet.Deposit(amount);
                    succeeded = true;
                    break;
                case Action.Withdraw:
                    succeeded = wallet.Withdraw(amount);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void Undo()
        {
            if (!succeeded) return;
            switch (action)
            {
                case Action.Deposit:
                    wallet.Withdraw(amount);
                    break;
                case Action.Withdraw:
                    wallet.Deposit(amount);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
