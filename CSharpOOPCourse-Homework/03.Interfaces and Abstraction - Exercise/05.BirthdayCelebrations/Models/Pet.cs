using BirthdayCelebrations.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCelebrations.Models
{
    public class Pet : IAnimal, IBirthable
    {
        public Pet(string name, DateTime birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }

        public string Name { get; init; }

        public DateTime Birthdate { get; init; }
    }
}
