using LogForMe.ConsoleApp.Appenders.Contracts;
using LogForMe.ConsoleApp.Loggers.Contracts;
using LogForMe.ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
        }
        public void Warning(string dateTime, string information)
        {
            throw new NotImplementedException();
        }
        public void Error(string dateTime, string information)
        {
            throw new NotImplementedException();
        }

        public void Critical(string dateTime, string information)
        {
            throw new NotImplementedException();
        }

        public void Fatal(string dateTime, string information)
        {
            LogMessage(dateTime, information);
        }

        private void LogMessage(string dateTime, string information)
        {
            Message message = new(dateTime, information);

            foreach (IAppender appender in this.appenders)
            {
                appender.AppendMessage(message);
            }
        }
    }
}
