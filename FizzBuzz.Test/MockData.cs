using FizzBuzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Test
{
    public static class MockData
    {
        public static List<ValuesToPrint> GetTestDataForOtherDays()
        {
            var list = new List<ValuesToPrint>
            {
                new ValuesToPrint
                {
                    Id = 1,
                    Value = Convert.ToString(1)
                },
                new ValuesToPrint
                {
                    Id = 2,
                    Value = Convert.ToString(2)
                },
                new ValuesToPrint
                {
                    Id = 3,
                    Value = "Fizz"
                },
                new ValuesToPrint
                {
                    Id = 4,
                    Value = Convert.ToString(4)
                },
                new ValuesToPrint
                {
                    Id = 5,
                    Value = "Buzz"
                },
                new ValuesToPrint
                {
                    Id = 6,
                    Value = "Fizz"
                },
                new ValuesToPrint
                {
                    Id = 7,
                    Value = Convert.ToString(7)
                },
                new ValuesToPrint
                {
                    Id = 8,
                    Value = Convert.ToString(8)
                },
                new ValuesToPrint
                {
                    Id = 9,
                    Value = "Fizz"
                },
                new ValuesToPrint
                {
                    Id = 10,
                    Value = "Buzz"
                },
                new ValuesToPrint
                {
                    Id = 11,
                    Value = Convert.ToString(11)
                },
                new ValuesToPrint
                {
                    Id = 12,
                    Value = "Fizz"
                },
                new ValuesToPrint
                {
                    Id = 13,
                    Value = Convert.ToString(11)
                },
                new ValuesToPrint
                {
                    Id = 14,
                    Value = Convert.ToString(11)
                },
                new ValuesToPrint
                {
                    Id = 15,
                    Value = "FizzBuzz"
                }
            };
            return list;
        }

        public static List<ValuesToPrint> GetTestDataForWednesday()
        {
            var list = new List<ValuesToPrint>
            {
                new ValuesToPrint
                {
                    Id = 1,
                    Value = Convert.ToString(1)
                },
                new ValuesToPrint
                {
                    Id = 2,
                    Value = Convert.ToString(2)
                },
                new ValuesToPrint
                {
                    Id = 3,
                    Value = "Wizz"
                },
                new ValuesToPrint
                {
                    Id = 4,
                    Value = Convert.ToString(4)
                },
                new ValuesToPrint
                {
                    Id = 5,
                    Value = "Wuzz"
                },
                new ValuesToPrint
                {
                    Id = 6,
                    Value = "Wizz"
                },
                new ValuesToPrint
                {
                    Id = 7,
                    Value = Convert.ToString(7)
                },
                new ValuesToPrint
                {
                    Id = 8,
                    Value = Convert.ToString(8)
                },
                new ValuesToPrint
                {
                    Id = 9,
                    Value = "Wizz"
                },
                new ValuesToPrint
                {
                    Id = 10,
                    Value = "Wuzz"
                },
                new ValuesToPrint
                {
                    Id = 11,
                    Value = Convert.ToString(11)
                },
                new ValuesToPrint
                {
                    Id = 12,
                    Value = "Wizz"
                },
                new ValuesToPrint
                {
                    Id = 13,
                    Value = Convert.ToString(11)
                },
                new ValuesToPrint
                {
                    Id = 14,
                    Value = Convert.ToString(11)
                },
                new ValuesToPrint
                {
                    Id = 15,
                    Value = "WizzWuzz"
                }
            };
            return list;
        }

    }
}
