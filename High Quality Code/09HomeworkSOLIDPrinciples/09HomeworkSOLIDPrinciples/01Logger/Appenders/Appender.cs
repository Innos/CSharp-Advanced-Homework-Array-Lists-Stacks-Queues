namespace _01Logger.Appenders
{
    using System;
    using _01Logger.Enums;
    using _01Logger.Interfaces;

    public abstract class Appender : IAppender
    {
        protected Appender(ILayout formatter)
        {
            this.Formatter = formatter;
            this.ReportLevel = ReportLevel.Info;
        }

        public ILayout Formatter { get; set; }

        public ReportLevel ReportLevel { get; set; }

        public abstract void Append(string message, ReportLevel level, DateTime date);

    }
}
