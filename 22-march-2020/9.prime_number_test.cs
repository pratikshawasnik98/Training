using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _9.prime_number;
namespace _9.prime_number_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program obj = new Program();
            int res = obj.prime(31);
            int actual = 0;
            Assert.AreEqual(res, actual);
        }
    }
}
