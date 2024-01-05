using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogForMe.ConsoleApp.Exceptions
{
    public class InvalidPathException : Exception
    {
        private const string DefaultMessage = "Path is not valid! Path cannot be null or contain white spaces!";

        public InvalidPathException() : base(DefaultMessage)
        { }

        public InvalidPathException(string message) : base(message)
        { }
    }
}
