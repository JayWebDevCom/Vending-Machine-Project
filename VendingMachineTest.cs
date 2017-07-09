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
    }
}
