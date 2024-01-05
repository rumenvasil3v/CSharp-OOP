using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogForMe.ConsoleApp.Exceptions
{
    public class EmptyInformationException : Exception
    {
        private const string DefaultMessage = "Information is not valid! Message cannot be empty, null or contain white spaces!";

        public EmptyInformationException() : base(DefaultMessage)
        { }

        public EmptyInformationException(string message) : base(message)
        { }
    }
}
