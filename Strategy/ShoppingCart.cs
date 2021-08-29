using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
	// The context defines the interface of interest to clients.
	public class ShoppingCart
    {
		//List of items
		List<Item> Items;

		public ShoppingCart()
		{
			this.Items = new List<Item>();
		}

		public void AddItem(Item item)
		{
			this.Items.Add(item);
		}

		public void RemoveItem(Item item)
		{
			this.Items.Remove(item);
		}

		public int CalculateTotal()
		{
			int sum = 0;
			foreach (var item in Items)
			{
				sum += item.getPrice();
			}
			return sum;
		}

		public void Pay(IPaymentStrategy paymentMethod)
		{
			int amount = CalculateTotal();
			paymentMethod.pay(amount);
		}
	}
	public class Item
	{

		private String ItemName;
		private int Price;

		public Item(String itemName, int price)
		{
			this.ItemName = itemName;
			this.Price = price;
		}

		public String getUpcCode()
		{
			return ItemName;
		}

		public int getPrice()
		{
			return Price;
		}

	}
}
