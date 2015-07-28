namespace _01Logger.Layouts
{
    using System;
    using _01Logger.Enums;
    using _01Logger.Interfaces;

    public abstract class Layout : IFormat
    {
        public abstract string Format(string message, ReportLevel level, DateTime date);
    }
}
