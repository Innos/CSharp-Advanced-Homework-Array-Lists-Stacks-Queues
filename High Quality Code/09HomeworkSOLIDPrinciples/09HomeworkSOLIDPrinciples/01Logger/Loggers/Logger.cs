namespace _01Logger.Loggers
{
    using System;
    using System.Collections.Generic;
    using _01Logger.Interfaces;

    public class Logger : ILogger
    {
        public Logger(params IAppender[] appenders)
        {
            this.Appenders = new List<IAppender>(appenders);
        }

        public List<IAppender> Appenders { get; set; }

        private void Log(string msg, ReportLevel level)
        {
            var date = DateTime.Now;

            foreach (var appender in this.Appenders)
            {
                appender.ValidatedAppend(msg,level,date);
            }
        }
        public void Info(string msg)
        {
            this.Log(msg,ReportLevel.Info);
        }
        public void Warn(string msg)
        {
            this.Log(msg, ReportLevel.Warn);
        }
        public void Error(string msg)
        {
            this.Log(msg, ReportLevel.Error);
        }
        public void Critical(string msg)
        {
            this.Log(msg, ReportLevel.Critical);
        }
        public void Fatal(string msg)
        {
            this.Log(msg, ReportLevel.Fatal);
        }

    }
}
