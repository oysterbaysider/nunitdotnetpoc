using System;
using CalculatorLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace Calculator.UnitTest
{
    [TestClass]
    public class CalculatorUnitTests
    {
        [TestMethod]
        public void ShouldAddTwoNumbers()
        {
            var cal = new SimpleCalculator();
            var result = cal.Add(3, 5);
            Assert.AreEqual(8, result);
        }
    }
}
