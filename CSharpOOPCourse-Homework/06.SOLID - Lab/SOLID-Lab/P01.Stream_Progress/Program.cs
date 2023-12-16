using P01.Stream_Progress.Contracts;
using System;

namespace P01.Stream_Progress
{
    public class Program
    {
        static void Main()
        {
            IStream musicStream = new Music("Wagner", "Wagner, Orchestral Highlights From Operas", 20, 200);
            StreamProgressInfo streamProgress = new(musicStream);
            Console.WriteLine(streamProgress.CalculateCurrentPercent());

            IStream fileStream = new File("text.txt", 20, 200);
            StreamProgressInfo streamProgress2 = new(fileStream);
            Console.WriteLine(streamProgress2.CalculateCurrentPercent());
        }
    }
}
