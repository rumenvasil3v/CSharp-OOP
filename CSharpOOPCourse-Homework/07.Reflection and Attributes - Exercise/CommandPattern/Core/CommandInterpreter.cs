using CommandPattern.Core.Contracts;
using CommandPattern.Exceptions;
using System;
using System.Linq;
using System.Reflection;

namespace CommandPattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] currentArguments = args.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string commandName = currentArguments[0];

            Type type = Assembly
                .GetEntryAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name == $"{commandName}Command");

            if (type is null)
            {
                throw new InvalidCommandException();
            }

            ICommand currentCommand = Activator.CreateInstance(type) as ICommand;
            string result = currentCommand.Execute(currentArguments.Skip(1).ToArray());

            return result;
        }
    }
}