namespace ShapeAreaCalculator.Shapes.Abstract
{
    //Фигуры не делят состояние поэтому интерфейс
    public interface IShape
    {
        /// <summary>
        /// Calculate shape area
        /// </summary>
        /// <returns></returns>
        double CalculateArea();
    }
}

