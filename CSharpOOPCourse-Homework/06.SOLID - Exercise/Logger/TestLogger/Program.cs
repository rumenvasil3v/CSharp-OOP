﻿using LogForMe.ConsoleApp.Appenders;
using LogForMe.ConsoleApp.Appenders.Contracts;
using LogForMe.ConsoleApp.Layouts.Contracts;
using LogForMe.ConsoleApp.Loggers;
using LogForMe.ConsoleApp.Loggers.Contracts;
using LogForMe.ConsoleApp.Enums;
using LogForMe.ConsoleApp.Layouts;
using LogForMe.ConsoleApp.IO;
using TestLogger.IO.Contracts;
using TestLogger.IO;
using TestLogger.Core.Contracts;
using TestLogger.Core;
using TestLogger.Factories.Contracts;
using TestLogger.Factories;

IReader reader = new ConsoleReader();
IWriter writer = new ConsoleWriter();
IAppenderFactory appenderFactory = new AppendFactory();
ILayoutFactory layoutFactory = new LayoutFactory();

IEngine engine = new Engine(reader, writer, appenderFactory, layoutFactory);
engine.Run();

//ILayout simpleLayout = new XmlLayout();
//IAppender consoleAppender = new ConsoleAppender(simpleLayout);
//consoleAppender.ReportLevel = ReportLevel.Error;

//ILogger logger = new Logger(consoleAppender);

//logger.Info("3/31/2015 5:33:07 PM", "Everything seems fine");
//logger.Warning("3/31/2015 5:33:07 PM", "Warning: ping is too high - disconnect imminent");
//logger.Error("3/31/2015 5:33:07 PM", "Error parsing request");
//logger.Critical("3/31/2015 5:33:07 PM", "No connection string found in App.config");
//logger.Fatal("3/31/2015 5:33:07 PM", "mscorlib.dll does not respond");

//var simpleLayout = new SimpleLayout();
//var consoleAppender = new ConsoleAppender(simpleLayout);

//var file = new LogFile();
//var fileAppender = new FileAppender(simpleLayout, file);

//var logger = new Logger(consoleAppender, fileAppender);
//logger.Error("3/26/2015 2:08:11 PM", "Error parsing JSON.");
//logger.Info("3/26/2015 2:08:11 PM", "User Pesho successfully registered.");

//var xmlLayout = new XmlLayout();
//var consoleAppender = new ConsoleAppender(xmlLayout);
//var logger = new Logger(consoleAppender);

//logger.Fatal("3/31/2015 5:23:54 PM", "mscorlib.dll does not respond");
//logger.Critical("3/31/2015 5:23:54 PM", "No connection string found in App.config");