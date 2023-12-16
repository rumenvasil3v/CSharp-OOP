using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04.Recharge.Contracts
{
    public interface IWorker
    {
        int WorkingHours { get; }

        void Work(int hours);
    }
}
