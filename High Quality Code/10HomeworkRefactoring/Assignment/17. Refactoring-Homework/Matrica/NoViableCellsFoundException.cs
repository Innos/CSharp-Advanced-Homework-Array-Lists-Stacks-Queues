namespace Matrix
{
    using System;

    public class NoViableCellsFoundException : Exception
    {
        public NoViableCellsFoundException(string message) : base(message)
        {
            
        }
    }
}
