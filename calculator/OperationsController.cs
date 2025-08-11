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
            decimal operand1 = decimal.Parse(operands[0]);
            decimal operand2 = decimal.TryParse(operands[1], out decimal parsedValue) ? parsedValue : 0;

            return $"{operand1 + operand2}";
        }
    }
}
