using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorok
{
    public class ArithmeticExpression
    {
        private static readonly string[] VALID_OPERATORS = { "+", "-", "*", "/", "div", "mod" };
        public int FirstOperand { get; set; }
        public string Operaator { get; set; }
        public int SecondOperand { get; set; }

        public ArithmeticExpression(int firstOperand, string operaator, int secondOperand)
        {
            FirstOperand = firstOperand;
            Operaator = operaator;
            SecondOperand = secondOperand;
        }

        public bool OperaatorIsValid()
        {
            return VALID_OPERATORS.Contains(Operaator);
        }

        public string Result()
        {
            if (!OperaatorIsValid())
                return "Hibás operátor!";

            switch (Operaator)
            {
                case "+":
                    return (FirstOperand + SecondOperand).ToString();
                case "-":
                    return (FirstOperand - SecondOperand).ToString();
                case "*":
                    return (FirstOperand * SecondOperand).ToString();
                case "/":
                    if (SecondOperand == 0) break;
                    return (FirstOperand * 1.0 / SecondOperand).ToString();
                case "div":
                    if (SecondOperand == 0) break;
                    return (FirstOperand / SecondOperand).ToString();
                case "mod":
                    if (SecondOperand == 0) break;
                    return (FirstOperand % SecondOperand).ToString();
            }

            return "Egyéb hiba!";
        }

        public static ArithmeticExpression StringToArithmeticExpression(string expressionString)
        {
            string[] expressionArray = expressionString.Split(' ');
            
            if (expressionArray.Length != 3)
                return null;

            Int32.TryParse(expressionArray[0], out int firstOperand);
            string operaator = expressionArray[1];
            Int32.TryParse(expressionArray[2], out int secondOperand);

            return new ArithmeticExpression(firstOperand, operaator, secondOperand);
        }

        public new string ToString()
        {
            return $"{FirstOperand} {Operaator} {SecondOperand} = {Result()}";
        }
    }
}
