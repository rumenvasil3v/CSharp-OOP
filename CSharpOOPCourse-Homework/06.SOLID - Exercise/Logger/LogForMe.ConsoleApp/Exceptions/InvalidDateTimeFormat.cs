using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogForMe.ConsoleApp.Exceptions
{
    public class InvalidDateTimeFormat : Exception
    {
        private const string DefaultMessage = "Date Time doesn't contain such a format!";

        public InvalidDateTimeFormat() : base(DefaultMessage)
        { }

        public InvalidDateTimeFormat(string message) : base(message)
        { }
    }
}
