using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class OperationsController
    {
        public string Addition(string displayText)
        {
            string[] operands = displayText.Split('+');

            return $"{Decimal.Parse(operands[0]) + Decimal.Parse(operands[1])}";
        }
    }
}
