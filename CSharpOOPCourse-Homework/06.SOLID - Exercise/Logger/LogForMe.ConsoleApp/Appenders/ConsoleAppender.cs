using LogForMe.ConsoleApp.Appenders.Contracts;
using LogForMe.ConsoleApp.Enums;
using LogForMe.ConsoleApp.Layouts.Contracts;
using LogForMe.ConsoleApp.Models;

namespace LogForMe.ConsoleApp.Appenders
{
    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout) : base(layout)
        { }

        public ConsoleAppender(ILayout layout, ReportLevel reportLevel) : base(layout, reportLevel)
        { }

        public override void AppendMessage(Message message)
        {
            Console.WriteLine(string.Format(Layout.Format, message.DateTime, message.ReportLevel, message.Text));

            MessagesAppended++;
        }
    }
}