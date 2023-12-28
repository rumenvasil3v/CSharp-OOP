using System;

namespace CommandPattern.Exceptions
{
    public class InvalidCommandException : Exception
    {
        private const string DefaultMessage = "Command doesn't exist! Be careful!";

        public InvalidCommandException() : base (DefaultMessage)
        {

        }

        public InvalidCommandException(string message) : base(message)
        {

        }
    }
}
