using FizzBuzz.Interfaces;
using FizzBuzz.Models;

namespace FizzBuzz.Logic
{
    public class DevideByThree : IRule
    {
        public ValuesToPrint Calculation(int value)
        {
            ValuesToPrint val = new ValuesToPrint
            {
                Id = value,
                Value = DateTime.Now.DayOfWeek.ToString() == "Wednesday" ? "Wizz" : "Fizz"
            };
            return val;
        }

        public bool isValid(int value)
        {
            return value % 3 == 0 && value % 5 != 0;
        }
    }
}
