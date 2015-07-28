
namespace _01Logger.Interfaces
{
    using System;

    public interface IFormat
    {
        string Format(string message, ReportLevel level, DateTime date);
    }
}
