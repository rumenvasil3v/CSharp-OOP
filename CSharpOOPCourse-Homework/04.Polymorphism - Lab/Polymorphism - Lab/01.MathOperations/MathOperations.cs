﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    public class MathOperations
    {
        public int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public double Add(double firstNumber, double secondNumber, double thirdNumber)
        {
            return firstNumber + secondNumber + thirdNumber;
        }

        public decimal Add(decimal firstNumber, decimal secondNumber, decimal thirdNumber)
        {
            return firstNumber + secondNumber + thirdNumber;
        }
    }
}
