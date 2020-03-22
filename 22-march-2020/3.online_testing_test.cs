using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _3.online_testing;
namespace _3.online_testing_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
          //  Program obj = new Program();
            int res = Program.sum(10,15);
            int actual =25;
            //string expected = res;
            Assert.AreEqual(actual, res);
        }
    }
}
