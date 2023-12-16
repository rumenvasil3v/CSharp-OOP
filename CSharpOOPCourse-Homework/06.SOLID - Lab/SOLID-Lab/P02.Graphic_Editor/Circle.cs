using System;
using P02.Graphic_Editor.Contracts;

namespace P02.Graphic_Editor
{
    public class Circle : IShape
    {
        public void Draw()
        {
            double radius;
            double thickness = 0.4;
            ConsoleColor BorderColor = ConsoleColor.Yellow;
            Console.ForegroundColor = BorderColor;
            char symbol = '*';

            do
            {
                Console.Write("Enter radius:::: ");
                if (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0)
                {
                    Console.WriteLine("radius have to be positive number");
                }
            }
            while (radius <= 0);

            Console.WriteLine();
            double rIn = radius - thickness, rOut = radius + thickness;

            for (double y = radius; y >= -radius; --y)
            {
                for (double x = -radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
