using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem1
{
    public class Calculator
    {
        public int Calculate(IEnumerable<int> numbers)
        {
            return numbers.Where(i => i%3 == 0 || i%5 == 0).Sum();
        }
    }
}