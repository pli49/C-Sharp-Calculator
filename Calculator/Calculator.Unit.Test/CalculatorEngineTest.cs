using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Unit.Test
{


    [TestClass]
    public class CalculatorEngineTest
    {
        private readonly CalculatorEngine _calculatorEngine = new CalculatorEngine();
        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForNonSymbleOperation()
        {
            int number1 = 1;
            int number2 = 2;
            double result = _calculatorEngine.Calculate(number1, "add", number2);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForSymbleOperation()
        {
            int number1 = 1;
            int number2 = 2;
            double result = _calculatorEngine.Calculate(number1, "+", number2);
            Assert.AreEqual(3, result);
        }
    }
}
