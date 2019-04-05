using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        CalculatorApp.Calculator calc = new CalculatorApp.Calculator();

        [TestMethod]
        public void TestAddition()
        {
            int expected = 11;
            int a = 5;
            int b = 6;
            int result = calc.add(5,6);
            Assert.AreEqual(expected,result);
        }
    }
}
