using System;
namespace VendingMachineTechTest
{
    public class VendingMachine
    {
		Product[] items = new Product[2];
		public VendingMachine()
		{
			items[0] = new Product("Bottled Water", 0.60);
			items[1] = new Product("Crisps", 0.40);
		}

		public Array Items
		{
			get
			{
				return items;
			}
		}

		public void DisplayItems()
		{
			foreach (var item in items)
			{
                Console.Out.WriteLine("{0} - Price {1:c}p", item.Name, item.Price);
			}
		}  
	}
 
}
