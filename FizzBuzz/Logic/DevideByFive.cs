using FizzBuzz.Interfaces;
using FizzBuzz.Models;

namespace FizzBuzz.Logic
{
    public class DevideByFive : IRule
    {
        public ValuesToPrint Calculation(int value)
        {
            ValuesToPrint val = new ValuesToPrint
            {
                Id = value,
                Value = "Buzz"
            };
            return val;
        }

        public bool isValid(int value)
        {
            return value % 5 == 0 && value % 3 != 0;
        }
    }
}
