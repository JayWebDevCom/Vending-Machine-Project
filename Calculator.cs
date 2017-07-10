using System; namespace VendingMachineTechTest {
	public class Calculator
	{
		double acceptedCoin = 0.50;

		public Calculator()
		{
		}

		public double[] ReturnPaymentAndChange(Product product)
		{
			double cost = product.Price;
			double coinsRequired = Math.Ceiling(cost / acceptedCoin);
			double change = (coinsRequired * acceptedCoin) - cost;
			double[] paymentInfo = { coinsRequired, change };

			Console.Out.WriteLine("Please enter {0} x {1:c} coins", coinsRequired, acceptedCoin);
			Console.Out.WriteLine("Your change will be {0:c}", change);
			             return paymentInfo; 		}
	} }  