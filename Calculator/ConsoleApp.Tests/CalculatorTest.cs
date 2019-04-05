using NUnit.Framework;
using CalculatorApp;

namespace Tests
{
    public class CalculatorTest
    {
        Calculator calc;
        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        [Test]
        public void TestAddition()
        {
            int expected = 11;
            int a = 5;
            int b = 6;
            int result = calc.add(5, 6);
            Assert.AreEqual(expected,result);
        }
    }
}