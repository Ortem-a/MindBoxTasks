using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace TestProject2
{
    [TestClass]
    public class TestTriangle
    {
        [TestMethod]
        public void TestPerimeter()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            double expected = 12;
            double actual = triangle.GetPerimeter();

            Assert.AreEqual(expected, actual, 0.001, "Perimeter is not calculated currently");
        }

        [TestMethod]
        public void TestSquare()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            double expected = 6;
            double actual = triangle.GetSquare();

            Assert.AreEqual(expected, actual, 0.001, "Square is not calculated currently");
        }

        [TestMethod]
        public void TestIsRight()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            bool expected = true;
            bool actual = triangle.IsRight();

            Assert.AreEqual(expected, actual, "Triangle is not right");
        }
    }

    [TestClass]
    public class TestRectangle
    {
        [TestMethod]
        public void TestPerimeter()
        {
            Rectangle rectangle = new Rectangle(3, 4);
            double expected = 14;
            double actual = rectangle.GetPerimeter();

            Assert.AreEqual(expected, actual, 0.001, "Perimeter is not calculated currently");
        }

        [TestMethod]
        public void TestSquare()
        {
            Rectangle rectangle = new Rectangle(3, 4);
            double expected = 12;
            double actual = rectangle.GetSquare();

            Assert.AreEqual(expected, actual, 0.001, "Square is not calculated currently");
        }
    }

    [TestClass]
    public class TestCircle
    {
        [TestMethod]
        public void TestPerimeter()
        {
            Circle circle = new Circle(1);
            double expected = 2 * 1 * 3.14;
            double actual = circle.GetPerimeter();

            Assert.AreEqual(expected, actual, 0.01, "Perimeter is not calculated currently");
        }

        [TestMethod]
        public void TestSquare()
        {
            Circle circle = new Circle(1);
            double expected = 3.14;
            double actual = circle.GetSquare();

            Assert.AreEqual(expected, actual, 0.1, "Square is not calculated currently");
        }
    }
}