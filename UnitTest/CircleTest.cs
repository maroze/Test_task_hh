using AreaCalculation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAreaCircle()
        {
            Circle circle = new Circle(30){ };

            Assert.AreEqual(circle.Calculate(), 2827.43);
        }

        [TestMethod]
         public void TestAreaCircle2()
        {
            Circle circle = new Circle(0);

            Assert.ThrowsException<Exception>(() => circle.Calculate());
        }

        [TestMethod]
        public void TestAreaCircle3()
        {
            Circle circle = new Circle(-3);

            Assert.ThrowsException<Exception>(() => circle.Calculate());
        }

    }
}

