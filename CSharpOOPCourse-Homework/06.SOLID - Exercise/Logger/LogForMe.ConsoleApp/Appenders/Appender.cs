using LogForMe.ConsoleApp.Appenders.Contracts;
using LogForMe.ConsoleApp.Enums;
using LogForMe.ConsoleApp.Layouts.Contracts;
using LogForMe.ConsoleApp.Models;

namespace LogForMe.ConsoleApp.Appenders
{
    public abstract class Appender : IAppender
    {
        protected Appender(ILayout layout, ReportLevel reportLevel = ReportLevel.Info)
        {
            this.Layout = layout;
            this.ReportLevel = reportLevel;
        }

        public ILayout Layout { get; private set; }

        public ReportLevel ReportLevel { get; set; }

        public int MessagesAppended { get; protected set; }

        public abstract void AppendMessage(Message message);

        public override string ToString()
        {
            return $"Appender type: {this.GetType().Name}, Layout type: {Layout.GetType().Name}, Report level: {ReportLevel.ToString().ToUpper()}, Messages appended: {MessagesAppended}";
        }
    }
}
