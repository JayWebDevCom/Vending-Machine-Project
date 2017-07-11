using NUnit.Framework;
using System;
namespace VendingMachineTechTest
{
    [TestFixture()]
    public class InventoryTest
    {
        [Test()]
        public void InventoryInstantiation()
        {
            Inventory inventory = new Inventory();
            Assert.IsInstanceOf<Inventory>(inventory);
        }

		[Test()]
		public void InventoryReturnsItsItems()
		{
			Inventory inventory = new Inventory();
            Assert.AreEqual(2, inventory.Items.Length);
		}
    }
}