using demo.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public class PhaserEngine : IStartEngine
    {
        public void Start()
        {
            Console.WriteLine("You are starting the game with phaser engine!!!");
            Console.WriteLine("Enjoy!!!");
        }
    }
}
