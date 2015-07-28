namespace _01Logger
{
    using _01Logger.Appenders;
    using _01Logger.Layouts;
    using _01Logger.Loggers;

    internal class LoggerTest
    {
        private static void Main(string[] args)
        {
            var simpleLayout = new SimpleLayout();
            var xmlLayout = new XmlLayout();
            var jsonLayout = new JsonLayout();

            var consoleAppender = new ConsoleAppender(simpleLayout);
            var fileAppender = new FileAppender(jsonLayout,"log.txt");
            consoleAppender.ReportLevel = ReportLevel.Error;

            Logger logger = new Logger(consoleAppender,fileAppender);

            logger.Error("Error parsing JSON.");
            logger.Info(string.Format("User {0} successfully registered.", "Pesho"));
            logger.Warn("Warning - missing files.");


            fileAppender.Close();
        }
    }
}
