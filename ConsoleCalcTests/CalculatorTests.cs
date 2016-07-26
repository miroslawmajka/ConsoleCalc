using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CsCalc = CsCalculator.Calculator;
using VbCalc = VbCalculator.Calculator;

namespace ConsoleCalc.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void CsharpAddTest()
        {
            var subject = new CsCalc();

            var result = subject.Add(new List<int> { 4, 5, 6 });

            Assert.AreEqual(15, result);
        }

        [TestMethod()]
        public void CsharpSubtractest()
        {
            var subject = new CsCalc();

            var result = subject.Subtract(8, 2);

            Assert.AreEqual(6, result);
        }

        [TestMethod()]
        public void VbAddTest()
        {
            var subject = new VbCalc();

            var result = subject.Add(new List<int> { 4, 5, 6 });

            Assert.AreEqual(15, result);
        }

        [TestMethod()]
        public void VbSubtractTest()
        {
            var subject = new VbCalc();

            var result = subject.Subtract(8, 2);

            Assert.AreEqual(6, result);
        }
    }
}