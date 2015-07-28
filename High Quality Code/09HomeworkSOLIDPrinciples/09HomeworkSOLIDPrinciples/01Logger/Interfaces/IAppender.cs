namespace _01Logger.Interfaces
{
    using System;

    public interface IAppender : IAppend
    {
        ReportLevel ReportLevel { get; set; }

        void ValidatedAppend(string message, ReportLevel level, DateTime date);
    }
}
