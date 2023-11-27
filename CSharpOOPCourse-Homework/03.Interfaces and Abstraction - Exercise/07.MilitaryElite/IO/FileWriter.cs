using _03.Telephony.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Telephony.IO
{
    public class FileWriter : IWriter
    {
        public void WriteLine(string text)
        {
            using StreamWriter streamWriter = new("../../../text.txt", true);
            streamWriter.WriteLine(text);
        }
    }
}
