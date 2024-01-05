namespace LogForMe.ConsoleApp.Exceptions
{
    public class InvalidExtensionException : Exception
    {
        private const string DefaultMessage = "Extension is not valid! File extension cannot be null, empty or contain white spaces!";

        public InvalidExtensionException() : base(DefaultMessage)
        { }

        public InvalidExtensionException(string message) : base(message)
        { }
    }
}