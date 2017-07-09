using System;
using System.Collections.Generic;
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

		public char RequestSelection()
		{
			List<char> accepted = new List<char>();

			Console.Out.WriteLine("Please make your selection...");

			foreach (var item in items)
			{
				accepted.Add(item.Name[0]);
				Console.Out.WriteLine("Please enter {0} For {1}.", item.Name[0], item.Name);
			}

			char selection = Convert.ToChar(Console.ReadLine().ToUpper());


			while (!accepted.Contains(selection))
			{
				Console.Out.WriteLine("{0} Not vailable, please choose again.", selection);
				selection = Convert.ToChar(Console.ReadLine().ToUpper());
			}

			return selection;
		} 
	}
 
}
