using LogForMe.ConsoleApp.Appenders.Contracts;
using LogForMe.ConsoleApp.Enums;
using LogForMe.ConsoleApp.Layouts.Contracts;
using LogForMe.ConsoleApp.Models;

namespace LogForMe.ConsoleApp.Appenders
{
    public class ConsoleAppender : IAppender
    {

        public ConsoleAppender(ILayout layout)
        {
            this.Layout = layout;
        }

        public ILayout Layout { get; private set; }

        public ReportLevel ReportLevel { get; set; }

        public void AppendMessage(Message message)
        {
            Console.WriteLine(message);
        }
    }
}