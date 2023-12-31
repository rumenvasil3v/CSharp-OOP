﻿using MilitaryElite.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private List<IPrivate> privateSoldiers;

        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary, List<IPrivate> privateSoldiers) : base(id, firstName, lastName, salary)
        {
            this.privateSoldiers = privateSoldiers;
        }

        public IReadOnlyCollection<IPrivate> Privates => privateSoldiers;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Privates:");

            foreach (var currentPrivate in this.Privates)
            {
                sb.AppendLine($"  {currentPrivate.ToString()}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
