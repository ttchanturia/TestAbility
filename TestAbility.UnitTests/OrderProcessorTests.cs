using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAbility.UnitTests
{
    [TestClass]
    public class OrderProcessorTests
    {
        [TestMethod]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {

        }
    }



    public class FakeShippingCalculator : IShippingCalculator
    {

    }
}
