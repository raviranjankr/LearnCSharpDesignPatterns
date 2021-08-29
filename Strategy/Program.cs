using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
			ShoppingCart cart = new ShoppingCart();

			Item itemA = new Item("Item A", 10);
			Item itemB = new Item("Item B", 20);

			cart.AddItem(itemA);
			cart.AddItem(itemB);

			//pay by paypal
			cart.Pay(new PaypalStrategy("abc@domain.com", "pwd"));

			//pay by credit card
			cart.Pay(new CreditCardStrategy("Ravi Ranjan Kumar", "543216789", "123", "10/25"));

			Console.ReadLine();
        }
    }
}
