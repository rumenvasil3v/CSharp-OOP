using LogForMe.ConsoleApp.Appenders.Contracts;
using LogForMe.ConsoleApp.Enums;
using LogForMe.ConsoleApp.IO;
using LogForMe.ConsoleApp.Layouts.Contracts;
using LogForMe.ConsoleApp.Models;

namespace LogForMe.ConsoleApp.Appenders
{
    public class FileAppender : IAppender
    {
        private const string Path = @"../../../log.txt";

        private LogFile logFileInfo;

        public FileAppender(ILayout layout, LogFile logFileInfo)
        {
            this.Layout = layout;
            this.logFileInfo = logFileInfo;
        }

        public ILayout Layout { get; private set; }

        public ReportLevel ReportLevel { get; set; }

        public void AppendMessage(Message message)
        {
            using (StreamWriter streamWriter = new(Path, true))
            {
                streamWriter.WriteLine(string.Format(Layout.Format, message.DateTime, message.ReportLevel, message.Text));
            }

            logFileInfo.Write(message, Layout);
        }
    }
}
