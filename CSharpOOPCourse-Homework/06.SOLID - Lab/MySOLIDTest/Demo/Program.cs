using demo;
using demo.Contracts;

IStartEngine unityStartEngine = new UnityEngine();

GameEngine engine = new(unityStartEngine, unityStartEngine.GetType().Name, "This is a highly useful engine!", DateTime.Now, "Dark Souls");
engine.StartGame();

IStartEngine unrealStartEngine = new UnrealEngine();

GameEngine engine2 = new(unrealStartEngine, unrealStartEngine.GetType().Name, "This is a highly useful engine!", DateTime.Now, "Dark Souls");
engine2.StartGame();


IStartEngine phaserStartEngine = new PhaserEngine();

GameEngine engine3 = new(phaserStartEngine, phaserStartEngine.GetType().Name, "This is a highly useful engine!", DateTime.Now, "Dark Souls");
engine3.StartGame();

IStartEngine godotStartEngine = new GodotEngine();

GameEngine engine4 = new(godotStartEngine, godotStartEngine.GetType().Name, "This is a highly useful engine!", DateTime.Now, "Dark Souls");
engine4.StartGame();