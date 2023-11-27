/*
Engineer 7 Peter Johnson 12.23 Marines Boat 2 Crane 17
Commando 19 George Stevenson 150.15 Airforces HairyFoot finished Freedom inProgress
End
 */

using MilitaryElite.Core;

namespace MilitaryElite
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