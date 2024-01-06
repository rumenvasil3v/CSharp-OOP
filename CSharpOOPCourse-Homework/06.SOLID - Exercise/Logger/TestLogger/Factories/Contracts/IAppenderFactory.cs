using LogForMe.ConsoleApp.Appenders.Contracts;
using LogForMe.ConsoleApp.Enums;
using LogForMe.ConsoleApp.IO.Contracts;
using LogForMe.ConsoleApp.Layouts.Contracts;

namespace TestLogger.Factories.Contracts
{
    public interface IAppenderFactory
    {
        IAppender CreateAppenderInstance(string appenderType, ILayout layout, ReportLevel reportLevel, ILogFile logFile = null);
    }
}
