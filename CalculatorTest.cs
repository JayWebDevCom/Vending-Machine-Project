using Moq;
using NUnit.Framework;
using System;
namespace VendingMachineTechTest
{
    [TestFixture()]
    public class CalculatorTest
    {
        [Test()]
        public void Instantitaion()
        {
			Calculator calculator = new Calculator();
			Assert.IsInstanceOf<Calculator>(calculator);
        }

        [Test()]
		public void CalculatesChangeAndCoinsRequired()
		{
			Calculator calculator = new Calculator();
            Product juice = new Product("Juice", 0.80d);
            double[] returned = calculator.PaymentAndChange(juice);
            var returnedFormatted = Convert.ToDecimal(returned[1]);

            Assert.AreEqual(2, returned[0]);
			Assert.AreEqual(0.20, returnedFormatted);
			Assert.AreEqual(2, returned.Length);
		}

		[Test()]
		public void CalculatesChangeAndCoinsRequiredTwo()
		{
			Calculator calculator = new Calculator();
			Product biscuits = new Product("Bisuits", 0.10d);
			double[] returned = calculator.PaymentAndChange(biscuits);
			
            Assert.AreEqual(1, returned[0]);
			Assert.AreEqual(0.40, returned[1]);
			Assert.AreEqual(2, returned.Length);
		}

		[Test()]
		public void CalculatesChangeAndCoinsRequiredThree()
		{
			Calculator calculator = new Calculator();
			Product biscuits = new Product("Chocolate", 0.50);
			double[] returned = calculator.PaymentAndChange(biscuits);

			Assert.AreEqual(1, returned[0]);
			Assert.AreEqual(0, returned[1]);
			Assert.AreEqual(2, returned.Length);
		}
    }
}
