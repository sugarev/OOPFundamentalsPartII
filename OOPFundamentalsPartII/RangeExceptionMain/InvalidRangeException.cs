namespace RangeExceptionMain
{
    using System;
    public class InvalidRangeException<T> : Exception
    {
        public new string Message { get; set; }

        public T Start { get; private set; }

        public T End { get; private set; }

        public InvalidRangeException(string message, T start, T end)
        {
            this.Message = message;
            this.Start = start;
            this.End = end;
        }
    }
}
