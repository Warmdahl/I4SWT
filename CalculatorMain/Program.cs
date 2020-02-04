using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorMain
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.Calculator Calc = new Calculator.Calculator();

            Console.WriteLine($"Adding 2 and 5 gives: {Calc.Add(2, 5)}");
        }
    }
}
