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

		[Test()]
		public void TakePaymentMethodReturnsPaymentProductChangeCrisps()
		{
            using (StringReader sr = new StringReader("0.50"))
            {
				using (StringWriter sw = new StringWriter())
				{
					Console.SetIn(sr);
					Console.SetOut(sw);
					VendingMachine vendingMachine = new VendingMachine();
					Product product = new Product("Crisps", 0.40);
					vendingMachine.TakePayment(1, 0.10, product);
					Assert.AreEqual("Please enter a payment of 50p as 0.50\n"+
                                    "Received 1, Outstanding 0\nThank you for your payment "+
                                    "of £0.50\nYour product Crisps has been dispensed\nYour change "+
                                    "of £0.10 has been dispensed also\n", sw.ToString());
				}
            }
			
		}

		[Test()]
		public void TakePaymentMethodReturnsPaymentProductChangeBottledWater()
		{
			using (StringReader sr = new StringReader("0.50"))
			{
                using (StringReader sr2 = new StringReader("0.50"))
                {
                    using (StringWriter sw = new StringWriter())
                    {
                        Console.SetIn(sr);
                        Console.SetOut(sw);
                        VendingMachine vendingMachine = new VendingMachine();
                        Product product = new Product("Bottled Water", 0.60);
                        vendingMachine.TakePayment(2, 0.40, product);
                        Assert.AreEqual("Please enter a payment of 50p as 0.50\n" +
                                        "Received 1, Outstanding 0\nThank you for your payment " +
                                        "of £0.50\nYour product Botteld Water has been dispensed\nYour change " +
                                        "of £0.40 has been dispensed also\n", sw.ToString());
                    }
                }
			}

		}
    }
}