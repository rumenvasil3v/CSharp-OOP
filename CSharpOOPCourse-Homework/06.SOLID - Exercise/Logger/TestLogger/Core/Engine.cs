using LogForMe.ConsoleApp.Appenders;
using LogForMe.ConsoleApp.Appenders.Contracts;
using LogForMe.ConsoleApp.Enums;
using LogForMe.ConsoleApp.IO;
using LogForMe.ConsoleApp.IO.Contracts;
using LogForMe.ConsoleApp.Layouts.Contracts;
using LogForMe.ConsoleApp.Loggers;
using LogForMe.ConsoleApp.Loggers.Contracts;
using System.Text;
using TestLogger.Core.Contracts;
using TestLogger.Factories.Contracts;
using TestLogger.IO.Contracts;
using TestLogger.Layouts;

namespace TestLogger.Core
{
    public class Engine : IEngine
    {
        private const string CommandCondition = "END";

        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly IAppenderFactory appenderFactory;
        private readonly ILayoutFactory layoutFactory;

        private ICollection<IAppender> appenders;
        private ILogger logger;

        public Engine(IReader reader, IWriter writer, IAppenderFactory appenderFactory, ILayoutFactory layoutFactory)
        {
            this.reader = reader;
            this.writer = writer;
            this.appenderFactory = appenderFactory;
            this.layoutFactory = layoutFactory;
            this.appenders = new List<IAppender>();
        }

        public void Run()
        {
            GetAppenders();

            LogMessages();
            foreach (var appender in appenders)
            {
                writer.WriteLine(appender.ToString());
            }
        }

        private void GetAppenders()
        {
            int numberOfAppenders = int.Parse(reader.ReadLine());

            for (int i = 0; i < numberOfAppenders; i++)
            {
                try
                {
                    string[] appendersInfo = reader.ReadLine().Split(" ");

                    string typeOfAppender = appendersInfo[0];
                    string typeOfLayout = appendersInfo[1];
                    ReportLevel reportLevel = ReportLevel.Info;

                    if (appendersInfo.Length > 2)
                    {
                        //string currentReportLevel = MakeStringLowerCase(appendersInfo[2]);
                        reportLevel = Enum.Parse<ReportLevel>(appendersInfo[2], true);
                    }

                    ILayout layout = GetLayout(typeOfLayout);
                    IAppender appender = GetAppender(typeOfAppender, layout, reportLevel);

                    appenders.Add(appender);
                }
                catch (Exception ex)
                {
                    writer.WriteLine(ex.Message);
                }
            }
        }

        private void LogMessages()
        {
            logger = new Logger(appenders.ToArray());

            string command;
            while ((command = reader.ReadLine()) != CommandCondition)
            {
                string[] commandArguments = command.Split("|");

                string reportType = commandArguments[0];
                //string reportLevel = MakeStringLowerCase(reportType);

                ReportLevel currentReportLevel = Enum.Parse<ReportLevel>(reportType, true);

                string dateTime = commandArguments[1];
                string message = commandArguments[2];

                try
                {
                    switch (currentReportLevel)
                    {
                        case ReportLevel.Info:
                            logger.Info(dateTime, message);
                            break;
                        case ReportLevel.Warning:
                            logger.Warning(dateTime, message);
                            break;
                        case ReportLevel.Error:
                            logger.Error(dateTime, message);
                            break;
                        case ReportLevel.Critical:
                            logger.Critical(dateTime, message);
                            break;
                        case ReportLevel.Fatal:
                            logger.Fatal(dateTime, message);
                            break;
                        default:
                            throw new InvalidOperationException("No such a Report Level");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private IAppender GetAppender(string typeOfAppender, ILayout layout, ReportLevel reportLevel)
        {
            IAppender appender;

            if (typeOfAppender == "FileAppender")
            {
                ILogFile logFile = new LogFile("TestLogFileToday", "txt", @"D:\");

                appender = appenderFactory.CreateAppenderInstance(typeOfAppender, layout, reportLevel, logFile);
            }
            else
            {
                appender = appenderFactory.CreateAppenderInstance(typeOfAppender, layout, reportLevel);
            }

            return appender;
        }

        private ILayout GetLayout(string typeOfLayout)
        {
            ILayout layout = layoutFactory.CreateLayoutInstance(typeOfLayout);

            return layout;
        }

        //private string MakeStringLowerCase(string reportLevel)
        //{
        //    char[] charArray = reportLevel.Skip(1).ToArray();

        //    string secondPart = new string(charArray);
        //    secondPart = secondPart.ToLower();

        //    reportLevel = reportLevel[0] + secondPart;

        //    return reportLevel;
        //}
    }
}