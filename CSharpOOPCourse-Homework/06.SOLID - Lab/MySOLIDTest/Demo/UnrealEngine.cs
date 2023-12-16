using demo.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public class UnrealEngine : IStartEngine
    {
        public void Start()
        {
            Console.WriteLine("You are starting the game with unreal engine!!!");
            Console.WriteLine("Enjoy!!!");
        }
    }
}
