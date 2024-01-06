using LogForMe.ConsoleApp.Layouts.Contracts;
using LogForMe.ConsoleApp.Models;

namespace LogForMe.ConsoleApp.IO.Contracts
{
    public interface ILogFile
    {
        string Name { get; }
        
        string Extension { get; }

        string Path { get; }

        string FullPath { get; }

        int Size { get; }

        void Write(Message message, ILayout layout);
    }
}
