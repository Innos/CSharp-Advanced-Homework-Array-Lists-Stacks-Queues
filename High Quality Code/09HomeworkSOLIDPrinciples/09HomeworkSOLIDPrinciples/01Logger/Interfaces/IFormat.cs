namespace _01Logger.Interfaces
{
    using System;

    using _01Logger.Enums;

    public interface IFormat
    {
        string Format(string message, ReportLevel level, DateTime date);
    }
}
