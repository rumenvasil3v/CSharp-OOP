using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogForMe.ConsoleApp.Layouts.Contracts
{
    public interface ILayout
    {
        string Format { get; }
    }
}
