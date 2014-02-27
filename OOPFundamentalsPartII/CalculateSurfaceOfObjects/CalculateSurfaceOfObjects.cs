namespace CalculateSurfaceOfObjects
{
    using System;
    using System.Collections.Generic;
    class CalculateSurfaceOfObjects
    {
        static void Main()
        {
            Triangle triangle = new Triangle(5, 3);

            Rectangular rect = new Rectangular(9, 4);

            Circle circle = new Circle(2);

            List<Shape> shapes = new List<Shape>();
            shapes.Add(triangle);
            shapes.Add(rect);
            shapes.Add(circle);

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape);
            }
        }
    }
}
