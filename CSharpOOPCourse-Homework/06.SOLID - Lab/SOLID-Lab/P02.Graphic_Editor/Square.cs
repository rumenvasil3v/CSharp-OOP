using System;
using P02.Graphic_Editor.Contracts;

namespace P02.Graphic_Editor
{
    public class Square : IShape
    {
        public void Draw()
        {
            ConsoleColor color = ConsoleColor.Yellow;
            Console.ForegroundColor = color;

            Console.Write("Enter value: ");
            double value = double.Parse(Console.ReadLine());
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("Value cannot be non-positive! Enter a positive value");
            }

            for (int i = 0; i < value; i++)
            {
                Console.Write('*');
                Console.Write(' ');
            }

            Console.WriteLine();

            for (int n = 1; n < value - 1; n++)
            {
                Console.Write('*');
                Console.Write(new string(' ', (int)(value - 2) + ((int)value - 1)));
                Console.WriteLine('*');
            }

            for (int i = 0; i < value; i++)
            {
                Console.Write('*');
                Console.Write(' ');
            }

            Console.WriteLine();
        }
    }
}
