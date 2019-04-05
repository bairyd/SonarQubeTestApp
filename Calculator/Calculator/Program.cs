using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.WriteLine("Adding 1 + 2: " + calc.add(1, 2));
        }
    }
}
