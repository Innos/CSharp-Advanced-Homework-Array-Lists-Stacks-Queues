namespace _01Logger.Layouts
{
    using System;
    using _01Logger.Enums;

    public class SimpleLayout : Layout
    {
        public override string Format(string message, ReportLevel level, DateTime date)
        {
            return string.Format("{0} - {1} - {2}", date, level, message);
        }
    }
}
