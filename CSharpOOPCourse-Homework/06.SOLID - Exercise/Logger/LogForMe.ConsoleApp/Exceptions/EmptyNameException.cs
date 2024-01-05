using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogForMe.ConsoleApp.Exceptions
{
    public class EmptyNameException : Exception
    {
        private const string DefaultMessage = "Name is not valid! Name cannot be empty, null or contain white spaces!";

        public EmptyNameException() : base(DefaultMessage)
        { }

        public EmptyNameException(string message) : base(message)
        { }
    }
}
