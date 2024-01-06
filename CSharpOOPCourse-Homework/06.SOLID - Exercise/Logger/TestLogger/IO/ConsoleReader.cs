using TestLogger.IO.Contracts;

namespace TestLogger.IO
{
    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}