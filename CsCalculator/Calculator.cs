using System.Collections.Generic;
using System.Linq;

namespace CsCalculator
{
    public class Calculator
    {
        public int Add(IEnumerable<int> elements)
        {
            return elements.Sum();
        }

        public int Subtract(int el1, int el2)
        {
            return el1 - el2;
        }
    }
}