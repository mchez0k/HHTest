using HHTest.Shapes;
using Xunit;

namespace HHTest.Tests
{
    public class ShapeTests
    {
        [Fact]
        public void CircleArea_Test()
        {
            var circle = new Circle(10);
            Assert.Equal(Math.PI * 100, circle.CalculateArea(), 5);
        }

        [Fact]
        public void TriangleArea_Test()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.Equal(6, triangle.CalculateArea(), 5);
            Assert.True(triangle.IsRight());
        }

        [Fact]
        public void TriangleInvalidSides_Test()
        {
            Assert.Throws<Exception>(() => new Triangle(1, 1, 10));
        }

        [Fact]
        public void CircleInvalidSides_Test()
        {
            Assert.Throws<Exception>(() => new Circle(null));
        }
    }
}
