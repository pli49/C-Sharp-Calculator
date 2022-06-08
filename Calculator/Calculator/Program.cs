using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* This main part of the code takes 3 inputs from consol, catches errors, if no error,
              proceed to the calculation for +, -, *, / and return the result */
            try
            {
                InputConverter inputConverter = new InputConverter();
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                double input1 = inputConverter.ConvertInputToNumber(Console.ReadLine());
                string operation = Console.ReadLine();
                double input2 = inputConverter.ConvertInputToNumber(Console.ReadLine());

                double result = calculatorEngine.Calculate(input1, operation, input2);
                Console.WriteLine(result);

            }
            catch (Exception ex)
            {
                //TODO: start logging exceptions
                Console.WriteLine(ex.ToString());
            }
            
        }
    }
}
