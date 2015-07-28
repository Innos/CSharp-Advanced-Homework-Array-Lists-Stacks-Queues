namespace _01Logger.Interfaces
{
    using System;
    using _01Logger.Enums;

    public interface IAppender : IAppend
    {
        ReportLevel ReportLevel { get; set; }

        void ValidatedAppend(string message, ReportLevel level, DateTime date);
    }
}
