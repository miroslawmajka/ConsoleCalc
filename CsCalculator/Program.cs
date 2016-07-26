using System;
using System.Collections.Generic;

namespace CsCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();

            var elements = new List<int> { 1, 2, 3 };

            Console.WriteLine($"Adding elements {string.Join(", ", elements)}: {calculator.Add(elements)}.");
            Console.WriteLine($"Subtracting 4 and 1: {calculator.Subtract(4, 1)}.");

            Console.ReadKey();
        }
    }
}