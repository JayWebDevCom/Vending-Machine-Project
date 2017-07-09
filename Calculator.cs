using System; namespace VendingMachineTechTest {
	public class Calculator
	{
		double acceptedCoin = 0.50;

		public Calculator()
		{
		}

		public double[] PaymentAndChange(Product product)
		{
			double cost = product.Price;
			double coinsRequired = Math.Ceiling(cost / acceptedCoin);
			double change = (coinsRequired * acceptedCoin) - cost;
			double[] paymentInfo = { coinsRequired, change };

	             return paymentInfo;
		}
	} }  