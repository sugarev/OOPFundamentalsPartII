namespace CalculateSurfaceOfObjects
{
    using System;
    public class Rectangular : Shape, IDimention
    {
        public Rectangular(double width, double height)
            : base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            double surface = this.Height * this.Width;
            return surface;
        }

        // public override string ToString()
        // {
        //     return base.ToString();
        // }
    }
}
