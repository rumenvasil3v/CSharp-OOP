using demo.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public class GameEngine
    {
        private IStartEngine engine;

        public GameEngine(IStartEngine startEngine, string name, string description, DateTime yearFounded, string gameName)
        {
            this.engine = startEngine;
            this.Name = name;
            this.Description = description;
            this.YearFounded = yearFounded;
            this.GameName = gameName;
        }

        public string Name { get; private set; }

        public string Description { get; private set; }

        public DateTime YearFounded { get; private set; }

        public string GameName { get; private set; }    

        public void StartGame()
        {
            engine.Start();
        }
    }
}