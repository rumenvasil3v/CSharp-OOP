using demo.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class GodotEngine : IStartEngine
    {
        public void Start()
        {
            Console.WriteLine("You are starting the game with godot engine!!!");
            Console.WriteLine("Enjoy!!!");
        }
    }
}
