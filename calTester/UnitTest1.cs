using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using calculator;

namespace calTester
{
    [TestClass]
    public class UnitTest1
    {
        calculation cal;
        [TestInitialize]
        public void SetUp()
        {
            cal = new calculator.calculation(10, 5);
        }

        [TestMethod]
        public void TestAddOperator()
        {
            Assert.AreEqual(cal.Execute("+"), 15);
        }
        [TestMethod]
        public void TestSubOperator()
        {
            Assert.AreEqual(cal.Execute("-"), 5);
        }
        [TestMethod]
        public void TestMulOperator()
        {
            Assert.AreEqual(cal.Execute("*"), 50);
        }
        [TestMethod]
        public void TestDivOperator()
        {
            Assert.AreEqual(cal.Execute("/"), 2);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivByZero()
        {
            calculation c = new calculation(2, 0);
            c.Execute("/");
        }
    }
}
