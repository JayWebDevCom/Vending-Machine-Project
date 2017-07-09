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

            Product product = vendingMachine.Find(selectionchar); 
            Calculator calculator = new Calculator();

            var paymentInfo = calculator.PaymentAndChange(product);

            vendingMachine.TakePayment(paymentInfo[0], paymentInfo[1], product);

		}
    }
}
