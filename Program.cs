using System;

namespace VendingMachineTechTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			var vendingMachine = new VendingMachine();

			vendingMachine.DisplayItems();

			var selectionChar = vendingMachine.RequestSelection();

            Product product = vendingMachine.FindAndReturnProduct(selectionChar); 
            Calculator calculator = new Calculator();

            var paymentInfo = calculator.ReturnPaymentAndChange(product.Price);

            vendingMachine.TakePayment(paymentInfo[0], paymentInfo[1], product);

		}
    }
}
