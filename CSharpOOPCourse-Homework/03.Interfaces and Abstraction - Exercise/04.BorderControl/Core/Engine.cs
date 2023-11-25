/*
Teo 31 7801211340
Peter 29 8007181534
IV-228 999999
Sam 54 3401018380
KKK-666 80808080
End
340
 */

using _03.Telephony.IO;
using _03.Telephony.IO.Interfaces;
using BorderControl.Models;
using BorderControl.Models.Interfaces;
using System.Reflection.PortableExecutable;

namespace BorderControl.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            List<IIdentifiable> identifiables = new List<IIdentifiable>();

            string command;
            while ((command = reader.ReadLine()) != "End")
            {
                string[] commandArguments = command.Split(" ");

                if (CheckIfTheIndividualIsCitizen(commandArguments))
                {
                    GetCitizenInfo(commandArguments, identifiables);
                }
                else
                {
                    GetRobotInfo(commandArguments, identifiables);
                }   
            }

            DetainIndividuals(identifiables, reader, writer);
        }

        private void DetainIndividuals(List<IIdentifiable> identifiables, IReader reader, IWriter writer)
        {
            string lastDigitsOfFakeId = reader.ReadLine();

            foreach (var identifiable in identifiables)
            {
                if (identifiable.Id.EndsWith(lastDigitsOfFakeId))
                {
                    writer.WriteLine(identifiable.Id);
                }
            }
        }

        private bool CheckIfTheIndividualIsCitizen(string[] commandArguments)
        {
            if (commandArguments.Length == 3)
            {
                return true;
            }

            return false;
        }

        private void GetCitizenInfo(string[] commandArguments, List<IIdentifiable> identifiables)
        {
            string personName = commandArguments[0];
            int personAge = int.Parse(commandArguments[1]);
            string personId = commandArguments[2];

            IIdentifiable identifiable = new Citizen(personName, personAge, personId);

            identifiables.Add(identifiable);
        }

        private void GetRobotInfo(string[] commandArguments, List<IIdentifiable> identifiables)
        {
            string robotModel = commandArguments[0];
            string robotId = commandArguments[1];

            IIdentifiable identifiable = new Robot(robotModel, robotId);

            identifiables.Add(identifiable);
        }
    }
}