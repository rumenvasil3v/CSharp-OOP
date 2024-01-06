using LogForMe.ConsoleApp.Enums;
using LogForMe.ConsoleApp.IO;
using LogForMe.ConsoleApp.IO.Contracts;
using LogForMe.ConsoleApp.Layouts.Contracts;
using LogForMe.ConsoleApp.Models;
using System.Text;

namespace LogForMe.ConsoleApp.Appenders
{
    public class FileAppender : Appender
    {
        public FileAppender(ILayout layout) : base(layout)
        { }

        public FileAppender(ILayout layout, ReportLevel reportLevel) : base(layout, reportLevel)
        { }

        public FileAppender(ILayout layout, ILogFile logFileInfo) : this(layout)
        {
            this.LogFile = logFileInfo;
        }

        public FileAppender(ILayout layout, ReportLevel reportLevel, ILogFile logFileInfo) : this(layout, reportLevel)
        {
            this.LogFile = logFileInfo;
        }

        public ILogFile LogFile { get; private set; }

        public override void AppendMessage(Message message)
        {
            using (StreamWriter streamWriter = new(LogFile.FullPath, true))
            {
                streamWriter.WriteLine(string.Format(Layout.Format, message.DateTime, message.ReportLevel, message.Text));
            }

            LogFile.Write(message, Layout);

            MessagesAppended++;
        }

        public override string ToString()
        {
            return base.ToString() + $", File size: {LogFile.Size}";
        }
    }
}