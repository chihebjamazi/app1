using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication2.Controllers;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            var controller = new ValuesController();
            //act
            int r = controller.multiplication(2, 5);
            //assert
            Assert.AreEqual(10, r);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //arrange

            var controller = new ValuesController();
            //act
            int r = controller.multiplication(3, 4);
            //assert
            Assert.AreEqual(12, r);


        }
    }
}
