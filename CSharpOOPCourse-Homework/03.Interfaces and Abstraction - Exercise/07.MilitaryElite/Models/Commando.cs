using MilitaryElite.Models.Enums;
using MilitaryElite.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        private List<IMission> missions;

        public Commando(int id, string firstName, string lastName, decimal salary, Corps corp, List<IMission> missions) : base(id, firstName, lastName, salary, corp)
        {
            this.missions = missions;
        }

        public IReadOnlyCollection<IMission> Missions => this.missions;

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(base.ToString());
            stringBuilder.AppendLine("Missions:");

            foreach (var mission in this.Missions)
            {
                if (mission.State == State.inProgress)
                {
                    stringBuilder.AppendLine($"  {mission.ToString()}");
                }
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
