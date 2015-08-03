namespace _01Logger.Interfaces
{
    using System;
    using _01Logger.Enums;

    public interface IAppender 
    {
        ReportLevel ReportLevel { get; set; }

        void Append(string message, ReportLevel level, DateTime date);
    }
}
