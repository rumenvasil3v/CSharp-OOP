using demo.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public class UnityEngine : IStartEngine
    {
        public void Start()
        {
            Console.WriteLine("You are starting the game with unity engine!!!");
            Console.WriteLine("Enjoy!!!");
        }
    }
}
