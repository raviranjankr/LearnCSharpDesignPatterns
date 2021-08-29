using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    // Concrete strategies implement the algorithm while following
    // the base strategy interface. The interface makes them
    // interchangeable in the context.
    public class PaypalStrategy:IPaymentStrategy
    {
        private String emailId;
        private String password;

        public PaypalStrategy(String email, String pwd)
        {
            this.emailId = email;
            this.password = pwd;
        }

        public void pay(int amount)
        {
            Console.WriteLine($"Total {amount} paid with paypal.");
        }
    }
}
