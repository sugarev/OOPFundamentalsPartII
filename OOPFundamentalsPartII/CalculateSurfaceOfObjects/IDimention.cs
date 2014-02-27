namespace CalculateSurfaceOfObjects
{
    using System;
    public interface IDimention
    {
        double Width { get; }
        double Height { get; }
        double CalculateSurface();
    }
}
