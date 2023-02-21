using AreaCalculation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        
        public void TestAreaTriangle()
        {
           Triangle triangle = new Triangle(10, 10, 20);

            Assert.ThrowsException<Exception>(() => triangle.Calculate());
        }

        [TestMethod]
        public void TestAreaTriangle2()
        {
            Triangle triangle = new Triangle(5, 10, 20);

            Assert.ThrowsException<Exception>(() => triangle.Calculate());
        }

        [TestMethod]
        public void TestAreaTriangle3()
        {
            Triangle triangle = new Triangle(15, -10, 20);

            Assert.ThrowsException<Exception>(() => triangle.Calculate());
        }

        [TestMethod]
        public void TestAreaTriangle4()
        {
            Triangle triangle = new Triangle(15, 10, 20);

            Assert.AreEqual(triangle.Calculate(), 72.62);
        }

        [TestMethod]
        public void TestRightTriangle5()
        {
            Triangle triangle = new Triangle(4, 3, 5);
           
            Assert.AreEqual( triangle.RightTriangle(), true);
        }

        [TestMethod]
        public void TestRightTriangle6()
        {
            Triangle triangle = new Triangle(10, 10, 15);

            Assert.AreEqual(triangle.RightTriangle(), false);
        }

    }
}

