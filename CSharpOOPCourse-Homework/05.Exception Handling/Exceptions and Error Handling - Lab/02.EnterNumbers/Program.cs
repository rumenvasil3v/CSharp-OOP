using System;

namespace Numbers
{
    public class StartUp
    {

        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            int count = 0;
            while (count < 10)
            {
                try
                {
                    int number = ReadNumber(1, 100);
                    numbers.Add(number);
                    count++;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Invalid Number!");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.ParamName);
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }

        static int ReadNumber(int start, int end)
        {
            bool isTrue = int.TryParse(Console.ReadLine(), out int number);

            if (isTrue && number > start && number < end)
            {
                return number;
            }
            else if (!isTrue)
            {
                throw new FormatException("Invalid Number!");
            }
            else
            {
                throw new ArgumentOutOfRangeException($"Your number is not in range {start} - {end}!");
            }
        }
    }
}