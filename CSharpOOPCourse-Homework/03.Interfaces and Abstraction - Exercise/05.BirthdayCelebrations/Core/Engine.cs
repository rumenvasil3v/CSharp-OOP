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
using BirthdayCelebrations.Models;
using BirthdayCelebrations.Models.Interfaces;
using BorderControl.Models;
using BorderControl.Models.Interfaces;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;

namespace BorderControl.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            List<IIdentifiable> identifiables = new List<IIdentifiable>();
            List<IBirthable> birthables = new List<IBirthable>();

            string command;
            while ((command = reader.ReadLine()) != "End")
            {
                string[] commandArguments = command.Split(" ");

                GetIndividualInfo(commandArguments, birthables, identifiables);
            }

            GetIndividualsBirthdates(birthables, reader, writer);
        }

        private void GetIndividualsBirthdates(List<IBirthable> birthables, IReader reader, IWriter writer)
        {
            int year = int.Parse(reader.ReadLine());

            foreach (var birthable in birthables)
            {
                if (birthable.Birthdate.Year == year)
                {
                    writer.WriteLine(birthable.Birthdate.ToString("dd/MM/yyyy"));
                }
            }
        }

        private void GetIndividualInfo(string[] commandArguments, List<IBirthable> birthables, List<IIdentifiable> identifiables)
        {
            string individual = commandArguments[0];

            switch (individual)
            {
                case "Pet":
                    GetPetInfo(commandArguments, birthables);
                    break;
                case "Citizen":
                    GetCitizenInfo(commandArguments, birthables);
                    break;
                case "Robot":
                    GetRobotInfo(commandArguments, identifiables);
                    break;
            }
        }

        private void GetCitizenInfo(string[] commandArguments, List<IBirthable> birthables)
        {
            string personName = commandArguments[1];
            int personAge = int.Parse(commandArguments[2]);
            string personId = commandArguments[3];
            DateTime birthdate = GetDate(commandArguments[4]);

            IBirthable birthable = new Citizen(personName, personAge, personId, birthdate);
            birthables.Add(birthable);
        }

        private DateTime GetDate(string date)
        {
            string[] dateArguments = date.Split('/');

            int day = int.Parse(dateArguments[0]);
            int month = int.Parse(dateArguments[1]);
            int year = int.Parse(dateArguments[2]);

            DateTime currentDate = new(year, month, day);

            return currentDate;
        }

        private void GetRobotInfo(string[] commandArguments, List<IIdentifiable> identifiables)
        {
            string robotModel = commandArguments[1];
            string robotId = commandArguments[2];

            IIdentifiable identifiable = new Robot(robotModel, robotId);
            identifiables.Add(identifiable);
        }

        private void GetPetInfo(string[] commandArguments, List<IBirthable> birthables)
        {
            string petName = commandArguments[1];
            DateTime birthdate = GetDate(commandArguments[2]);

            IBirthable birthable = new Pet(petName, birthdate);
            birthables.Add(birthable);
        }
    }
}