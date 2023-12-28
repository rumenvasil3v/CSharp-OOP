using LogForMe.ConsoleApp.Appenders;
using LogForMe.ConsoleApp.Appenders.Contracts;
using LogForMe.ConsoleApp.Layouts.Contracts;
using LogForMe.ConsoleApp.Loggers;
using LogForMe.ConsoleApp.Loggers.Contracts;
using LogForMe.ConsoleApp.Enums;

ILayout simpleLayout = new SimpleLayout();
IAppender consoleAppender = new ConsoleAppender(simpleLayout);
consoleAppender.ReportLevel = ReportLevel.Error;

ILogger logger = new Logger(consoleAppender);

logger.Info("3/31/2015 5:33:07 PM", "Everything seems fine");
logger.Warning("3/31/2015 5:33:07 PM", "Warning: ping is too high - disconnect imminent");
logger.Error("3/31/2015 5:33:07 PM", "Error parsing request");
logger.Critical("3/31/2015 5:33:07 PM", "No connection string found in App.config");
logger.Fatal("3/31/2015 5:33:07 PM", "mscorlib.dll does not respond");