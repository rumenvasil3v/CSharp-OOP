using P03.DetailPrinter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03.Detail_Printer
{
    public class Programmer : Employee
    {
        public Programmer(string name, string currentProgramLanguage) : base(name)
        {
            this.CurrentProgramLanguage = currentProgramLanguage;
        }

        public string CurrentProgramLanguage { get; protected set; }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine(base.ToString());
            sb.AppendLine("My job is to write code everyday and have no life!");

            return sb.ToString().Trim();
        }
    }
}