using Raiding.Core;
using Raiding.Core.Interfaces;
using Raiding.IO;
using Raiding.IO.Interfaces;

IReader reader = new ConsoleReader();
IWriter writer = new ConsoleWriter();

IEngine engine = new Engine(reader, writer);
engine.Run();