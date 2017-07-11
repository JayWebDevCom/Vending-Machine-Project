using NUnit.Framework;
using System;
namespace VendingMachineTechTest
{
    [TestFixture()]
    public class ProductTest
    {
        [Test()]
        public void ProductInstantiation()
        {
            Product crisps = new Product("Crisps", 0.40);
            Assert.IsInstanceOf<Product>(crisps);
		}

		[Test()]
		public void ProductName()
		{
			Product bottledWater = new Product("Bottled Water", 0.60);
			Assert.AreEqual("Bottled Water", bottledWater.Name);
		}

		[Test()]
		public void ProductPrice()
		{
			Product crisps = new Product("Crisps", 0.40);
			Assert.AreEqual(0.40, crisps.Price);
		}
    }
}
