using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Models
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string liviingRegion) : base(name, weight, liviingRegion)
        {
        }

        public override int FoodEaten { get; protected set; }
    }
}
