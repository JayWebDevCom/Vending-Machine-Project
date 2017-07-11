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
            Console.Out.WriteLine("Items available are as follows...");
            Console.Out.WriteLine();

			foreach (var item in items)
			{
                Console.Out.WriteLine("{0} - Price {1:c}p", item.Name, item.Price);
			}

            Console.Out.WriteLine();
		}

		public char RequestSelection()
		{
			List<char> accepted = new List<char>();

			Console.Out.WriteLine("Please make your selection...");

			foreach (var item in items)
			{
                char productCharacter = item.Name[0];
				accepted.Add(productCharacter);
				Console.Out.WriteLine("Please enter {0} for {1}.", productCharacter, item.Name);
			}

            char selection = Console.ReadLine().ToUpper()[0];

			while (!accepted.Contains(selection))
			{
				Console.Out.WriteLine("{0} Not vailable, please choose again.", selection);

                selection = Console.ReadLine().ToUpper()[0];
			}

			return selection;
		}

		public Product FindAndReturnProduct(char selection)
		{
			string stringselection = Convert.ToString(selection);

			var product = Array.Find(this.items, item => item.name.StartsWith(stringselection, StringComparison.Ordinal));

			return product;
		}

		public void TakePayment(double coinsRequired, double change, string productName)
		{
			int total = 0;
			double paymentReceived = 0;
			double receivedCoin = 0;

            Console.WriteLine("Please enter a payment of 50p as 0.50");

			while (total < coinsRequired)
			{
				try 
                {
                    receivedCoin = double.Parse(Console.ReadLine(), System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo);
					if (receivedCoin == 0.50)
					{
						total += 1;
						paymentReceived += receivedCoin;
						Console.Out.WriteLine("Received {0}, Outstanding {1}", total, coinsRequired - total);
					}
                    else
                    {
                        Console.Out.WriteLine("Sorry only 50p coins are accepted");
                    }
				}

                catch(FormatException)
                {
                    Console.Out.WriteLine("Sorry please enter a 50p coin as \"0.50\"");
                }
			}

            ThankCustomer(paymentReceived, productName, change);
		}

        public void ThankCustomer(double paymentReceived, string name, double change)
        {
			Console.WriteLine("Thank you for your payment of {0:c}", paymentReceived);
			Console.WriteLine("Your product {0} has been dispensed", name);
			Console.WriteLine("Your change of {0:c} has been dispensed also", change);
        }
	}
}
