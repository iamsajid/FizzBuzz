using FizzBuzz.Interfaces;
using FizzBuzz.Models;

namespace FizzBuzz.Logic
{
    public class Calculation
    {
        public  List<IRule> rules = new List<IRule>()
        {
            new GeneralRule(),
            new DevideByThree(),
            new DevideByFive(),
            new DevideByThreeAndFive()
        };
        
        public List<ValuesToPrint> GetValueList(int input)
        {
            List<ValuesToPrint> list = new List<ValuesToPrint>();
            for (int i = 1; i <= input; i++)
            {
                list.Add(rules.Find(x => x.isValid(i)).Calculation(i));
            }
            return list;
        }

    }
}
