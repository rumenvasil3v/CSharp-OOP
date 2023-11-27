using MilitaryElite.Models;
using MilitaryElite.Models.Enums;
using MilitaryElite.Models.Interfaces;
using System.Buffers;

namespace MilitaryElite.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            Dictionary<int, ISoldier> soldiers = new();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                try
                {
                    string[] commandArguments = command.Split(" ");
                    GetSoldierInfo(commandArguments, soldiers);
                }
                catch (Exception ex) { }
            }

            PrintSoldiers(soldiers);
        }

        private void PrintSoldiers(Dictionary<int, ISoldier> soldiers)
        {
            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier.Value.ToString());
            }
        }

        private void GetSoldierInfo(string[] commandArguments, Dictionary<int, ISoldier> soldiers)
        {
            string currentSoldier = commandArguments[0];

            switch (currentSoldier)
            {
                case "Private":
                    GetPrivateInfo(commandArguments.Skip(1).ToArray(), soldiers);
                    break;
                case "LieutenantGeneral":
                    GetLieutenantGeneralInfo(commandArguments.Skip(1).ToArray(), soldiers);
                    break;
                case "Engineer":
                    GetEngineerInfo(commandArguments.Skip(1).ToArray(), soldiers);
                    break;
                case "Commando":
                    GetCommandoInfo(commandArguments.Skip(1).ToArray(), soldiers);
                    break;
                case "Spy":
                    GetSpyInfo(commandArguments.Skip(1).ToArray(), soldiers);
                    break;
            }
        }

        private void GetPrivateInfo(string[] commandArguments, Dictionary<int, ISoldier> soldiers)
        {
            IPrivate privateSoldier = new Private(int.Parse(commandArguments[0]), commandArguments[1], commandArguments[2], decimal.Parse(commandArguments[3]));

            soldiers.Add(int.Parse(commandArguments[0]), privateSoldier);
        }

        private void GetLieutenantGeneralInfo(string[] commandArguments, Dictionary<int, ISoldier> soldiers)
        {
            List<IPrivate> privateSoldiers = new();

            for (int i = 4; i < commandArguments.Length; i++)
            {
                IPrivate currentPrivateSoldier = (IPrivate)soldiers[int.Parse(commandArguments[i])];
                privateSoldiers.Add(currentPrivateSoldier);
            }

            ILieutenantGeneral general = new LieutenantGeneral(int.Parse(commandArguments[0]), commandArguments[1], commandArguments[2], decimal.Parse(commandArguments[3]), privateSoldiers);

            soldiers.Add(int.Parse(commandArguments[0]), general);
        }

        private void GetEngineerInfo(string[] commandArguments, Dictionary<int, ISoldier> soldiers)
        {
            bool isCorpValid = Enum.TryParse(commandArguments[4], out Corps result);

            if (!isCorpValid)
            {
                throw new Exception();
            }

            List<IRepair> repairs = new();
            for (int i = 5; i < commandArguments.Length; i += 2)
            {
                IRepair repair = new Repair(commandArguments[i], int.Parse(commandArguments[i + 1]));
                repairs.Add(repair);
            }

            IEngineer engineer = new Engineer(int.Parse(commandArguments[0]), commandArguments[1], commandArguments[2], decimal.Parse(commandArguments[3]), result, repairs);

            soldiers.Add(int.Parse(commandArguments[0]), engineer);
        }

        private void GetCommandoInfo(string[] commandArguments, Dictionary<int, ISoldier> soldiers)
        {
            bool isCorpValid = Enum.TryParse(commandArguments[4], out Corps corpResult);

            if (!isCorpValid)
            {
                throw new Exception();
            }

            List<IMission> missions = new();
            for (int i = 5; i < commandArguments.Length; i += 2)
            {
                try
                {
                    bool isValid = Enum.TryParse(commandArguments[i + 1], out State result);

                    if (isValid)
                    {
                        IMission mission = new Mission(commandArguments[i], result);
                        missions.Add(mission);
                    }
                    else
                    {
                        throw new ArgumentException();
                    }
                }
                catch (Exception ex) { }
            }

            ICommando commando = new Commando(int.Parse(commandArguments[0]), commandArguments[1], commandArguments[2], decimal.Parse(commandArguments[3]), corpResult, missions);

            soldiers.Add(int.Parse(commandArguments[0]), commando);
        }

        private void GetSpyInfo(string[] commandArguments, Dictionary<int, ISoldier> soldiers)
        {
            ISpy spy = new Spy(int.Parse(commandArguments[0]), commandArguments[1], commandArguments[2], int.Parse(commandArguments[3]));

            soldiers.Add(int.Parse(commandArguments[0]), spy);
        }
    }
}