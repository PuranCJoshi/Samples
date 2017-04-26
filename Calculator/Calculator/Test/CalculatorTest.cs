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
            Console.WriteLine("Test Running");
        }
    }
}
