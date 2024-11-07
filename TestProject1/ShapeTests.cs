using ShapeAreaCalculator.Shapes;

namespace ShapeAreaCalculator.Tests
{
    public class ShapeTests
    {
        [Fact]
        public void Circle_Area_Calculation()
        {
            var circle = new Circle(5);
            Assert.Equal(78.53981633974483, circle.CalculateArea(), 5);
        }

        [Fact]
        public void Triangle_Area_Calculation()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.Equal(6, triangle.CalculateArea());
        }

        [Fact]
        public void Triangle_IsRightAngled()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRightAngled());
        }

        [Fact]
        public void Triangle_NotRightAngled()
        {
            var triangle = new Triangle(5, 5, 8);
            Assert.False(triangle.IsRightAngled());
        }

        [Fact]
        public void Circle_NegativeRadius_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }

        [Fact]
        public void Triangle_InvalidSides_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 3));
        }
    }
}