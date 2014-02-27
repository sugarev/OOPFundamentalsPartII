namespace CalculateSurfaceOfObjects
{
    using System;
    public class Triangle : Shape, IDimention
    {
        public Triangle(double width, double height)
            : base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            double surface = this.Height * this.Width / 2;
            return surface;
        }

        // public override string ToString()
        // {
        //     return base.ToString();
        // }
    }
}
