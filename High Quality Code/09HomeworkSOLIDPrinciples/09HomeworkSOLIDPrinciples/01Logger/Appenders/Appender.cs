namespace _01Logger.Appenders
{
    using System;
    using _01Logger.Enums;
    using _01Logger.Interfaces;

    public abstract class Appender : IAppender
    {
        protected Appender(IFormat formatter)
        {
            this.Formatter = formatter;
            this.ReportLevel = ReportLevel.Info;
        }

        public IFormat Formatter { get; set; }

        public ReportLevel ReportLevel { get; set; }

        public abstract void Append(string message, ReportLevel level, DateTime date);

        public void ValidatedAppend(string message, ReportLevel level, DateTime date)
        {
            if (level >= this.ReportLevel)
            {
                this.Append(message,level,date);
            }
        }

    }
}
