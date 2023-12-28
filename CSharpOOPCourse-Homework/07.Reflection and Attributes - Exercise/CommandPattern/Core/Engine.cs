using CommandPattern.Core.Contracts;
using CommandPattern.Exceptions;
using CommandPattern.IO.Contracts;

namespace CommandPattern.Core
{
    public class Engine : IEngine
    {
        private readonly ICommandInterpreter commandInterpreter;
        private readonly IReader reader;
        private readonly IWriter writer;

        public Engine(ICommandInterpreter commandInterpreter, IReader reader, IWriter writer)
        {
            this.commandInterpreter = commandInterpreter;
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            while (true)
            {
                string inputArguments = reader.ReadLine();

                try
                {
                    string result = commandInterpreter.Read(inputArguments);
                    writer.WriteLine(result);
                }
                catch (InvalidCommandException ex)
                {
                    writer.WriteLine(ex.Message);
                }
            }
        }
    }
}