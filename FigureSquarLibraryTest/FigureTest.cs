using System;
using Xunit;
using FigureSquareLibrary;

namespace FigureSquareLibraryTest
{
    public class FigureTest
    {
        [Fact]
        public void CreateCircleTest()
        {
            Figure figure = new Circle();
            Type expectedType = typeof(Circle);

            Assert.IsType(expectedType, figure);
        }

        [Fact]
        public void CreateTriangleTest()
        {
            Figure figure = new Triangle();
            Type expectedType = typeof(Triangle);

            Assert.IsType(expectedType, figure);
        }

        [Fact]
        public void CalculateCircleSquareTest()
        {
            Circle circle = new Circle(10);
            double expected = Math.PI * Math.Pow(2, 10);
            double actual = circle.Square();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsRectangularTest()
        {
            Triangle triangle = new Triangle(4, 5, 3);
            bool isRectangular = triangle.IsRectangular();

            Assert.True(isRectangular);
        }
        [Fact]
        public void CalculateSquareTest()
        {
            Triangle triangle = new Triangle(5, 6, 9);
            double p = (5 + 6 + 9) / 2;
            double expected = Math.Sqrt(p * (p - 5) * (p - 6) * (p - 9));
            double actual = triangle.Square();

            Assert.Equal(expected, actual);
        }
    }
}
