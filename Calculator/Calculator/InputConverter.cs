using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class InputConverter
    {
        /* Convert the string input to a double input, catches errors when the input cannot be converted to a double */
        public double ConvertInputToNumber(string TextInput)
        {
            double convertedNum;
            bool isDouble = double.TryParse(TextInput, out convertedNum);
            if (!isDouble) throw new ArgumentException("Expected a numeric value");
            return convertedNum;
        }
    }
}
