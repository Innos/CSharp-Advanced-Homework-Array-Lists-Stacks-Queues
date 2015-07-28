namespace _01Logger.Layouts
{
    using System;
    using System.Text;
    using _01Logger.Interfaces;

    public class JsonLayout : Layout
    {
        public override string Format(string message, ReportLevel level, DateTime date)
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine("{");
            output.AppendLine(string.Format("\"Message\" : \"{0}\"", message));
            output.AppendLine(string.Format("\"Level\" : \"{0}\"", level));
            output.AppendLine(string.Format("\"Date\" : \"{0}\"", date));
            output.AppendLine("}");

            return output.ToString();
        }

    }
}
