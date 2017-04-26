using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Test
{
    [TestFixture]
    class CalculatorTest
    {
        [Test]
        public void AddNumber()
        {
            var calculatorSvc = new CalculatorService();
            int result = calculatorSvc.Add(1, 2);
            Assert.True(result == 3, "Additon of 1,2 should be 3 but getting " + result);
        }
    }
}
