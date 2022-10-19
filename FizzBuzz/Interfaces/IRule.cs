using FizzBuzz.Models;

namespace FizzBuzz.Interfaces
{
    public interface IRule
    {
        public ValuesToPrint Calculation(int value);
        bool isValid(int value);
    }
}
