using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    // Concrete strategies implement the algorithm while following
    // the base strategy interface. The interface makes them
    // interchangeable in the context.
    public class CreditCardStrategy : IPaymentStrategy
    {
        private String name;
        private String cardNumber;
        private String cvv;
        private String dateOfExpiry;

        public CreditCardStrategy(String nm, String ccNum, String cvv, String expiryDate)
        {
            this.name = nm;
            this.cardNumber = ccNum;
            this.cvv = cvv;
            this.dateOfExpiry = expiryDate;
        }
        public void pay(int amount)
        {
            Console.WriteLine($"Total {amount} paid with credit/debit card");
        }
    }
}
