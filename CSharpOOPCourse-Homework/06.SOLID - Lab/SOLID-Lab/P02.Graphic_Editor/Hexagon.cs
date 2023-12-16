using System;
using P02.Graphic_Editor.Contracts;

namespace P02.Graphic_Editor
{
    public class Hexagon : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Hexagon drawn!!!");
        }
    }
}
