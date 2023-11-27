using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public interface IAnimal
    {
        string Name { get; }

        int Age { get; }

        string Type { get; }
    }
}
