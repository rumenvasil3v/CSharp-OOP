namespace LogForMe.ConsoleApp.Exceptions
{
    public class EmptyDateTimeException : Exception
    {
        private const string DefaultMessage = "Date Time is not valid! Date Time cannot be null, empty or contain white spaces!";

        public EmptyDateTimeException() : base(DefaultMessage)
        { }

        public EmptyDateTimeException(string message) : base(message)
        { }
    }
}
