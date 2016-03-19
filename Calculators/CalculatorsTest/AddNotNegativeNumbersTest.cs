using System;
using NUnit.Framework;
using Calculators;

namespace CalculatorsTest
{
    [TestFixture]
    class AddNotNegativeNumbersTest
    {
        [Test]
        [TestCase("_", 0)]
        [TestCase("+", 0)]
        [TestCase("-", 0)]
        [TestCase("++", 0)]
        [TestCase("--", 0)]
        [TestCase("12", 0)]
        [TestCase("12.5", 0)]
        [TestCase("-12", 0)]
        [TestCase("12,13", 25)]
        [TestCase("12,-13", -1)]
        [TestCase("12$-13", -1)]
        [TestCase("1267,-13", 1251)]
        [TestCase("12,5-13", 4)]
        [TestCase("s1,2", 3)]
        [TestCase("12,34Ы", 46)]
        [TestCase("-1,1-", -2)]
        [TestCase(",", 0)]
        [TestCase("1,", 1)]
        [TestCase(",1", 1)]
        [TestCase("1,-", 0)]
        [TestCase("-,1", 0)]
        [TestCase("-3,7", 4)]
        [TestCase("-3|7", 4)]
        [TestCase("14,-25,1,0", -10)]
        [TestCase("1,2,3,4,z", 10)]
        [TestCase("1,2,3,,4", 10)]
        [TestCase("1,2,3,4,-9", 1)]
        [TestCase("@@#", 0)]
        public void AddNotNegativeNumbers_EmptyString_ArgumentException(string str, int a)
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(calc.AddNotNegativeNumbers(str), a);
        }
    }
}
