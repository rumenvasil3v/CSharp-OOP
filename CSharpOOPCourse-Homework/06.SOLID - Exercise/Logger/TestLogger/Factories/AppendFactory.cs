using LogForMe.ConsoleApp.Appenders;
using LogForMe.ConsoleApp.Appenders.Contracts;
using LogForMe.ConsoleApp.Enums;
using LogForMe.ConsoleApp.IO;
using LogForMe.ConsoleApp.IO.Contracts;
using LogForMe.ConsoleApp.Layouts.Contracts;
using TestLogger.Factories.Contracts;

namespace TestLogger.Factories
{
    public class AppendFactory : IAppenderFactory
    {
        public IAppender CreateAppenderInstance(string appenderType, ILayout layout, ReportLevel reportLevel, ILogFile logFile = null)
        {
            switch (appenderType)
            {
                case "ConsoleAppender":
                    return new ConsoleAppender(layout, reportLevel);
                case "FileAppender":
                    return new FileAppender(layout, reportLevel, logFile);
                default:
                    throw new InvalidOperationException("No such a type exists.");
            }
        }
    }
}