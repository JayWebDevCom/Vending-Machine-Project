using NUnit.Framework;
using System;
using System.IO;
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
        public void ItemsArrayHasALengthOfTwo()
		{
			VendingMachine vendingMachine = new VendingMachine();
            Assert.AreEqual(2, vendingMachine.Items.Length);
		}

		[Test()]
		public void DisplayItemsMethodOutputsToConsole()
		{
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw); 
                VendingMachine vendingMachine = new VendingMachine();
                vendingMachine.DisplayItems();
                Assert.AreEqual("Bottled Water - Price £0.60p\nCrisps - Price £0.40p\n", sw.ToString());
            }
		}

		[Test()]
		public void RequestSelectionReceivesTheCorrectInputFromConsole()
		{
            using (StringWriter sw = new StringWriter())
            {
                using (StringReader sr = new StringReader("C"))
                {
                    Console.SetOut(sw);
                    Console.SetIn(sr);
					VendingMachine vendingMachine = new VendingMachine();
                    var selection = vendingMachine.RequestSelection();
                    Assert.AreEqual(selection, 'C');
                }
            }
		}

        [Test()]
        public void CharacterfromConsoleCorrectlyFindsCorrespondingItemOne()
		{
			VendingMachine vendingMachine = new VendingMachine();
            var product = vendingMachine.Find('C');
            Assert.AreEqual("Crisps", product.Name);
		}

        [Test()]
		public void CharacterfromConsoleCorrectlyFindsCorrespondingItemTwo()
		{
			VendingMachine vendingMachine = new VendingMachine();
			var product = vendingMachine.Find('B');
			Assert.AreEqual("Bottled Water", product.Name);
		}
    }
}
