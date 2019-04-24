using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathService
{
    [TestClass]
    public class MathServiceTests
    {
        [TestMethod]
        public void Add_CorrectInputs_ReturnsCorrectResult() // poprawne wartości dla dzielenia
        {
            double number1 = 10;
            double number2 = 5;

            double result = MathService.Divide(number1, number2);
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void Divide_IncorrectInputs_ShouldThrowException() // błędna wartość, dzielenie przez 0
        {
            double number1 = 10;
            double number2 = 0;

            Assert.ThrowsException<InvalidOperationException>(() => MathService.Divide(number1, number2));
        }

        [TestMethod]
        public void Multiply_CorrectInputs_ReturnsCorrectResult() // poprawna wartość dla mnożenia
        {
            double number1 = 5;
            double number2 = 3;

            double result = MathService.Multiply(number1, number2);
            Assert.AreEqual(15, result);
        }
    }
}
