using CalculatorLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Test
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void SholdAddTwoNumbers()
        {
            var cal = new SimpleCalculator();
            var result = cal.Add(3, 5);
            Assert.That(result, Is.EqualTo(8));
        }


        [Test]
        public void SholdMultiplyTwoNumbers()
        {
            var cal = new SimpleCalculator();
            var result = cal.Multiple(3, 5);
            Assert.That(result, Is.EqualTo(15));
        }
    }
}
