namespace CalculateSurfaceOfObjects
{
    using System;
    public class Circle : Shape, IDimention
    {
        public Circle(double radius)
            : base(radius)
        {
        }

        public override double CalculateSurface()
        {
            double surface = Math.PI * this.Width * this.Width;
            return surface;
        }
    }
}
