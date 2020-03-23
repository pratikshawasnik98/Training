using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using divide_testing;

namespace Project_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            divide obj = new divide();
            int res = obj.solution(10,2);
            int actual = 5;
            int expected = res;
            Assert.AreEqual(actual, expected);

        }
    }
}
