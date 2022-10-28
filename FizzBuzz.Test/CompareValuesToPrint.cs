using FizzBuzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Test
{
    public class CompareValuesToPrint : Comparer<ValuesToPrint>
    {
        public override int Compare(ValuesToPrint? x, ValuesToPrint? y)
        {
            int IdCompare = x.Id.CompareTo(y.Id);
            if (IdCompare != 0) { 
                int valueCompare = x.Value.CompareTo(y.Value);
                return IdCompare; 
            }
            return 0;
        }
    }
}
