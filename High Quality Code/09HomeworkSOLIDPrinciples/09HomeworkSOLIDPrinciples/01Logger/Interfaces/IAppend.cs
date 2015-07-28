namespace _01Logger.Interfaces
{
    using System;

    public interface IAppend
    {
        void Append(string message, ReportLevel level, DateTime date);
    }
}
