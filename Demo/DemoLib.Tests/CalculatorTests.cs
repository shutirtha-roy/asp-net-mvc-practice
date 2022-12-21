using NUnit.Framework;

namespace DemoLib.Tests
{
    public class CalculatorTests

    {
        [SetUp]
        public void Setup()
        {
        }

        [Test, Category("UnitTest")]
        public void Sum_ValidNumbers_ValidSum()
        {
            int a = 5;
            int b = 7;
            int expected = 12;

            Calculator calculator = new Calculator();
            int result = calculator.Sum(a, b);

            Assert.AreEqual(expected, result);
        }
    }
}