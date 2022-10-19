﻿using FizzBuzz.Interfaces;
using FizzBuzz.Models;

namespace FizzBuzz.Logic
{
    public class DevideByThreeAndFive : IRule
    {
        public ValuesToPrint Calculation(int value)
        {
            ValuesToPrint val = new ValuesToPrint
            {
                Id = value,
                Value = "FizzBuzz"
            };
            return val;
        }

        public bool isValid(int value)
        {
            return value % 3 == 0 && value % 5 == 0;
        }
    }
}
