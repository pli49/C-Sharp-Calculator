using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class CalculatorEngine
    {
        /* Take two inputs and an operation and proceed with the calculation, caches errors if any*/
        public double Calculate(double input1, string operation, double input2)
        {
            double result;
            switch (operation.ToLower())
            {
                case "add":
                case "+":
                    result = input1 + input2;
                    break;
                case "subtract":
                case "-":
                    result = input1 - input2;
                    break;
                case "multiply":
                case "*":
                    result = input1 * input2;
                    break;
                case "devide":
                case "/":
                    result = input1 / input2;
                    break;
                default:
                    throw new InvalidOperationException("The operation input is not recognized");
            }
            return result;
        }
    }
}
