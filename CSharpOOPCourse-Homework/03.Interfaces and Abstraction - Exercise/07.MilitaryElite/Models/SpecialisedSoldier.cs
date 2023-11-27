using MilitaryElite.Models.Enums;
using MilitaryElite.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite.Models
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        protected SpecialisedSoldier(int id, string firstName, string lastName, decimal salary, Corps corp) : base(id, firstName, lastName, salary)
        {
            this.Corp = corp;
        }

        public Corps Corp { get; private set; }

        public override string ToString()
        => base.ToString() + $"{Environment.NewLine}Corps: {Corp}";
    }
}
