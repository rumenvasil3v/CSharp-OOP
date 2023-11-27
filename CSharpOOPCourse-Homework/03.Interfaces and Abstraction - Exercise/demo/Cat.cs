using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public class Cat : IAnimal
    {
        public Cat(string name, int age, string type, string mood)
        {
            this.Name = name;
            this.Age = age;
            this.Type = type;
            this.Mood = mood;
        }

        public string Name { get; init; }

        public int Age { get; init; }

        public string Type { get; init; }

        public string Mood { get; init; }

        public void Sound()
        {
            Console.WriteLine("Meow...");
        }

        public override string ToString()
        {
            return $"Name: {this.Name} Age: {this.Age} Type: {this.Type} Mood: {this.Mood}";
        }
    }
}
