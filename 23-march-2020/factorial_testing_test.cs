using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using factorial_testing;

namespace factorial_testing_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            multiply obj = new multiply();
            int result = obj.multi(2);
            int actual = 4;
            int expected = result;
            Assert.AreEqual(expected, actual);
           // return 0;
        }
    }
}
