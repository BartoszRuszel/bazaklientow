using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaDanychKlientów
{
    class Kalkulator
    {
        public static double Add(double number1, double number2)
        {
            return number1 + number2;
        }
        public static double Minus(double number1, double number2)
        {
            return number1 - number2;
        }
        public static double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }
        public static double Divide(double number1, double number2)
        {
            if (number2 == 0)
                throw new InvalidOperationException(); // nie można dzielić przez 0
            return number1 / number2;
        }
    }
}
