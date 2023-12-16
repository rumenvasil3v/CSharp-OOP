using System;
using P02.Graphic_Editor.Contracts;

namespace P02.Graphic_Editor
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            ConsoleColor color = ConsoleColor.DarkYellow;
            Console.ForegroundColor = color;

            Console.Write("Enter width: ");
            double width = double.Parse(Console.ReadLine());
            if (width <= 0)
            {
                throw new ArgumentOutOfRangeException("Width cannot be non-positive! Enter a positive value");
            }

            Console.Write("Enter height: ");
            double height = double.Parse(Console.ReadLine());
            if (height <= 0)
            {
                throw new ArgumentOutOfRangeException("Height cannot be non-positive! Enter a positive value");
            }

            Console.WriteLine(new string('*', (int)width));

            for (int n = 1; n < height - 1; n++)
            {
                Console.Write('*');
                Console.Write(new string(' ', (int)width - 2));
                Console.Write('*');
                Console.WriteLine();
            }

            Console.WriteLine(new string('*', (int)width));
        }
    }
}
