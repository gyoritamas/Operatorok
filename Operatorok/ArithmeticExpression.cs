using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorok
{
    public class ArithmeticExpression
    {
        public int FirstOperand { get; set; }
        public string Operaator { get; set; }
        public int SecondOperand { get; set; }

        public ArithmeticExpression(int firstOperand, string operaator, int secondOperand)
        {
            FirstOperand = firstOperand;
            Operaator = operaator;
            SecondOperand = secondOperand;
        }
    }
}
