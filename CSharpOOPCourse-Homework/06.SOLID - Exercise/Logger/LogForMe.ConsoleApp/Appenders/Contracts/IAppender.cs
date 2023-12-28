using LogForMe.ConsoleApp.Enums;
using LogForMe.ConsoleApp.Layouts.Contracts;
using LogForMe.ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogForMe.ConsoleApp.Appenders.Contracts
{
    public interface IAppender
    {
        ILayout Layout { get; }

        ReportLevel ReportLevel { get; set; }

        void AppendMessage(Message message);
    }
}
