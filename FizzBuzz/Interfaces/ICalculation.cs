using FizzBuzz.Models;

namespace FizzBuzz.Interfaces
{
    public interface ICalculation
    {
        public List<ValuesToPrint> GetValueList(int input);
    }
}