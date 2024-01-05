using LogForMe.ConsoleApp.Exceptions;
using LogForMe.ConsoleApp.IO.Contracts;
using LogForMe.ConsoleApp.Layouts.Contracts;
using LogForMe.ConsoleApp.Models;
using System.Text;

namespace LogForMe.ConsoleApp.IO
{
    public class LogFile : ILogFile
    {
        private const string DefaultExtension = "txt";
        private readonly string DefaultName = $"Log_{DateTime.Now:MM-dd-yyyy-HH-mm-ss}";
        private readonly string DefaultPath = $"{Directory.GetCurrentDirectory()}";

        private StringBuilder stringBuilder;
        private readonly string name;
        private readonly string extension;
        private readonly string path;

        public LogFile()
        {
            this.Name = DefaultName;
            this.Extension = DefaultExtension;
            this.Path = DefaultPath;
            stringBuilder = new StringBuilder();
        }

        public LogFile(string name, string extension, string path)
        {
            this.Name = name;
            this.Extension = extension;
            this.Path = path;
        }

        public string Name
        {
            get => this.name;
            init
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new EmptyNameException();
                }

                this.name = value;
            }
        }

        public string Extension
        {
            get => this.extension;
            init
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new InvalidExtensionException();
                }

                this.extension = value;
            }
        }

        public string Path
        {
            get => this.path;
            init
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new InvalidPathException();
                }

                this.path = value;
            }
        }

        public string FullPath => System.IO.Path.GetFullPath($"{Path}/{Name}.{Extension}");

        public int Size => GetSizeOfFile();

        public void Write(Message message, ILayout layout)
        {
            stringBuilder.AppendLine(string.Format(layout.Format, message.DateTime, message.ReportLevel, message.Text));
        }

        private int GetSizeOfFile()
        {
            int size = 0;

            string messages = stringBuilder.ToString().Trim();
            foreach (var message in messages.Split('\n'))
            {
                foreach (var character in message)
                {
                    int characterCode = character;
                    size += characterCode;
                }
            }

            return size;
        }
    }
}