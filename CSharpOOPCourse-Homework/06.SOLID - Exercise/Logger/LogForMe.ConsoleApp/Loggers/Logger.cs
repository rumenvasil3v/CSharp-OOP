using LogForMe.ConsoleApp.Appenders.Contracts;
using LogForMe.ConsoleApp.Enums;
using LogForMe.ConsoleApp.Loggers.Contracts;
using LogForMe.ConsoleApp.Models;

namespace LogForMe.ConsoleApp.Loggers
{
    public class Logger : ILogger
    {
        private readonly ICollection<IAppender> appenders;

        public Logger(params IAppender[] appenders)
        {
            this.appenders = appenders;
        }

        public void Info(string dateTime, string information)
        {
            LogMessage(dateTime, information, ReportLevel.Info);
        }

        public void Warning(string dateTime, string information)
        {
            LogMessage(dateTime, information, ReportLevel.Warning);
        }

        public void Error(string dateTime, string information)
        {
            LogMessage(dateTime, information, ReportLevel.Error);
        }

        public void Critical(string dateTime, string information)
        {
            LogMessage(dateTime, information, ReportLevel.Critical);
        }

        public void Fatal(string dateTime, string information)
        {
            LogMessage(dateTime, information, ReportLevel.Fatal);
        }

        private void LogMessage(string dateTime, string information, ReportLevel reportLevel)
        {
            Message message = new(dateTime, information, reportLevel);

            foreach (IAppender appender in this.appenders)
            {
                if (message.ReportLevel >= appender.ReportLevel)
                {
                    appender.AppendMessage(message);
                }
            }
        }
    }
}