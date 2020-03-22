using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1.Online_testing;

namespace _1.online_testing_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            welcome obj = new welcome();
            string res = obj.nice("Welcome Friends !");
            string actual = "Have a Nice Day";
            string expected = res;
            Assert.AreEqual(actual, expected);
        }
    }
}
