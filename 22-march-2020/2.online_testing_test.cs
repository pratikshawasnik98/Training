using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2.online_testing;
namespace _2.online_testing_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            Program obj = new Program();
            string name = obj.nice("Welcome Friend ! " );
            
            string actual = "Have a Nice Day";
           
            Assert.AreEqual(actual, name);
        }
    }
}
