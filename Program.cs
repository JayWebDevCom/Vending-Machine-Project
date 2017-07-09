using System;

namespace VendingMachineTechTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			var vendingMachine = new VendingMachine();

			vendingMachine.DisplayItems();

			var selection = vendingMachine.RequestSelection();

			char selectionchar = Convert.ToChar(selection); 

		}
    }
}
