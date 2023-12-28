using LogForMe.ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogForMe.ConsoleApp.Loggers.Contracts
{
    public interface ILogger
    {
        void Info(string dateTime, string information);

        void Warning(string dateTime, string information);

        void Error(string dateTime, string information);

        void Critical(string dateTime, string information);

        void Fatal(string dateTime, string information);
    }
}
