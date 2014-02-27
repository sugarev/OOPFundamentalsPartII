namespace CalculateSurfaceOfObjects
{
    using System;
    public abstract class Shape : IDimention
    {
        public Shape(double width)
        {
            this.Width = width;
        }

        public Shape(double width, double height)
            : this(width)
        {
            this.Height = height;
        }
        
        public double Width { get; private set; }
        public double Height { get; protected set; }

        public abstract double CalculateSurface();

        public override string ToString()
        {
            return String.Format("{0} shape {1:0.00}", base.GetType().Name, this.CalculateSurface());
        }
    }
}
