using _03.Cards.Engine;
using _03.Cards.Engine.Interfaces;
using _03.Cards.IO;
using _03.Cards.IO.Interfaces;

IReader reader = new ConsoleReader();
IWriter writer = new ConsoleWriter();

IEngine engine = new Engine(reader, writer);
engine.Run();