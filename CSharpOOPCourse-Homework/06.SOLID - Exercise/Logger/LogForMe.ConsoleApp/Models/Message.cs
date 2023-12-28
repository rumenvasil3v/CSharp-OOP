using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogForMe.ConsoleApp.Models
{
    public class Message
    {
        private string dateTime;
        private string text;

        public Message(string dateTime, string text)
        {
            this.DateTime = dateTime;
            this.Text = text;
        }

        public string DateTime { get => dateTime; set => dateTime = value; }

        public string Text { get => this.text; set => this.text = value; }
    }
}