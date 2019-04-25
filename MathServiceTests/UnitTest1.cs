using System;
using BazaDanychKlientów;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathService
{
    [TestClass]
    public class MathServiceTests
    {
        [TestMethod]
        public void Add_CorrectInputs_ReturnsCorrectResult() // poprawne wartości dla dodawania
        {
            double number1 = 10;
            double number2 = 5;

            double result = Kalkulator.Add(number1, number2);
            Assert.AreEqual(15, result);
        }
        [TestMethod]
        public void Add_CorrectInputs_ReturnsWrongResult() // złe wartości dla dodawania
        {
            double number1 = 10;
            double number2 = 10;

            double result = Kalkulator.Add(number1, number2);
            Assert.AreNotEqual(15, result);
        }

        [TestMethod]
        public void Divide_IncorrectInputs_ShouldThrowException() // błędna wartość, dzielenie przez 0
        {
            double number1 = 10;
            double number2 = 0;

            Assert.ThrowsException<InvalidOperationException>(() => Kalkulator.Divide(number1, number2));
        }
        [TestMethod]
        public void Divide_CorrectInputs_ReturnsCorrectResult() // poprawna wartość dla dzielenia
        {
            double number1 = 10;
            double number2 = 2;

            double result = Kalkulator.Divide(number1, number2);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Multiply_CorrectInputs_ReturnsCorrectResult() // poprawna wartość dla mnożenia
        {
            double number1 = 5;
            double number2 = 3;

            double result = Kalkulator.Multiply(number1, number2);
            Assert.AreEqual(15, result);
        }
        
        [TestMethod]
        public void Multiply_CorrectInputs_ReturnsWrongResult() // zła wartość dla mnożenia
        {
            double number1 = 5;
            double number2 = 3;

            double result = Kalkulator.Multiply(number1, number2);
            Assert.AreNotEqual(30, result);
        }
        [TestMethod]
        public void Minus_CorrectInputs_ReturnsCorrectResult() // poprawne wartości dla odejmowania
        {
            double number1 = 10;
            double number2 = 5;

            double result = Kalkulator.Minus(number1, number2);
            Assert.AreEqual(5, result);
        }
        [TestMethod]
        public void Minus_CorrectInputs_ReturnsWrongResult() // złe wartości dla odejmowania
        {
            double number1 = 10;
            double number2 = 10;

            double result = Kalkulator.Minus(number1, number2);
            Assert.AreNotEqual(15, result);
        }
    }
}
