using LogForMe.ConsoleApp.Enums;
using LogForMe.ConsoleApp.Exceptions;
using LogForMe.ConsoleApp.Utils;

namespace LogForMe.ConsoleApp.Models
{
    public class Message
    {
        private string dateTime;
        private string text;
        private ReportLevel reportLevel;

        public Message(string dateTime, string text, ReportLevel reportLevel)
        {
            DateTime = dateTime;
            Text = text;
            ReportLevel = reportLevel;
        }

        public string DateTime 
        { 
            get => dateTime; 
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new EmptyDateTimeException();
                }

                if (!DateTimeValidator.ValidateDateTimeFormats(value))
                {
                    throw new InvalidDateTimeFormat();
                }

                dateTime = value;
            } 
        }

        public string Text 
        { 
            get => text;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new EmptyInformationException();
                }

                text = value;
            }
        }

        public ReportLevel ReportLevel { get => reportLevel; private set => reportLevel = value; }
    }
}