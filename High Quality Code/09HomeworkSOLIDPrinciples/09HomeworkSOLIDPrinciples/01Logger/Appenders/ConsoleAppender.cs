namespace _01Logger.Appenders
{
    using System;
    using _01Logger.Enums;
    using _01Logger.Interfaces;

    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout formatter)
            : base(formatter)
        {
        }

        public override void Append(string message, ReportLevel level, DateTime date)
        {
            if (level < this.ReportLevel)
            {
                return;
            }
            var output = this.Formatter.Format(message, level, date);
            Console.WriteLine(output);
        }
    }
}