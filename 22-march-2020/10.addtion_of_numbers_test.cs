using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _10.addtion_of_numbers;
namespace _10.addtion_of_numbers_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program obj = new Program();
            int sum = obj.separate(1234);
            int actual = 10;
            Assert.AreEqual(sum, actual);
        }
    }
}
