﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Component
{
    public class Calculator
    {

        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }
        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        public int Division(int number1, int number2)
        {
            return number1 / number2;
        }

    }
}
