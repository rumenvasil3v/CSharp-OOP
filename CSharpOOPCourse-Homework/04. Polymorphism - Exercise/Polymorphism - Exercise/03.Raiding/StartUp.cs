using Raiding.Core;
using Raiding.Core.Interfaces;
using Raiding.Factories;
using Raiding.Factories.Interfaces;
using Raiding.IO;
using Raiding.IO.Interfaces;

IReader reader = new ConsoleReader();
IWriter writer = new ConsoleWriter();
IBaseHeroFactory baseHeroFactory = new BaseHeroFactory();

IEngine engine = new Engine(reader, writer, baseHeroFactory);
engine.Run();