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
			Assert.AreEqual(bottledWater.Name, "Bottled Water");
		}

		[Test()]
		public void ProductPrice()
		{
			Product crisps = new Product("Crisps", 0.40);
			Assert.AreEqual(crisps.Price, 0.40);
		}
    }
}
