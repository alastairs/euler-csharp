using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = new Calculator().Calculate(Enumerable.Range(1, 999));
            Console.WriteLine(string.Format("Project Euler Problem 1 result is {0}.", result));
        }
    }
}
