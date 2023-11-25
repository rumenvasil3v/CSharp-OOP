using BorderControl.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl.Models
{
    public class Robot : IIdentifiable, IRobot
    {
        public Robot(string model, string id)
        {
            this.Id = id;
            this.Model = model;
        }

        public string Model { get; init; }

        public string Id { get; init; }
    }
}