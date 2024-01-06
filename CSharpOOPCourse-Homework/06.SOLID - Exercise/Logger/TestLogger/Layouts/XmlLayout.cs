﻿using LogForMe.ConsoleApp.Layouts.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLogger.Layouts
{
    public class XmlLayout : ILayout
    {
        public string Format
        {
            get
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("<log>");
                stringBuilder.AppendLine("   <date>{0}</date>");
                stringBuilder.AppendLine("   <level>{1}</level>");
                stringBuilder.AppendLine("   <message>{2}</message>");
                stringBuilder.AppendLine("</log>");

                return stringBuilder.ToString().Trim();
            }
        }
    }
}
