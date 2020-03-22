using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using calculate_force;
namespace force_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void test_nikita()
        {
            force cf = new force();
            float result = cf.nikita(20 , 10);
            Assert.AreEqual(result, 200);

        }
    }
}
