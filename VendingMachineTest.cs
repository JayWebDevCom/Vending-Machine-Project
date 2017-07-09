using NUnit.Framework;
using System;
namespace VendingMachineTechTest
{
    [TestFixture()]
    public class VendingMachineTest
    {
        [Test()]
        public void Instantiation()
        {
            VendingMachine vendingMachine = new VendingMachine();
            Assert.IsInstanceOf<VendingMachine>(vendingMachine);
        }

        [Test()]
        public void ItemsArrayOfProducts()
		{
			VendingMachine vendingMachine = new VendingMachine();
            Assert.AreEqual(3, vendingMachine.Items.Length);
		}
    }
}
