/*
0882134215 0882134333 0899a13421 0558123 3333123
http://softuni.bg http://youtube.com http://www.g00gle.com 
 */

using _03.Telephony.Core;

namespace _03.Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}