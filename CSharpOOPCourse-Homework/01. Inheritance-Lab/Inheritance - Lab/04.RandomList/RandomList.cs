﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private Random random;

        public RandomList()
        {
            this.random = new Random();
        }

        public string RandomString()
        {
            int index = random.Next(0, this.Count - 1);
            string element = this[index];
            this.RemoveAt(index);

            return element;
        }
    }
}
