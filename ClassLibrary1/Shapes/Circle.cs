using ShapeAreaCalculator.Shapes.Abstract;

namespace ShapeAreaCalculator.Shapes
{
    public class Circle : IShape
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Radius cannot be negative.");
            }

            _radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}