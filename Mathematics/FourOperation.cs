using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    public class FourOperation
    {
        public void Addition(int number1, int number2)
        {
            int totalAddition = number1 + number2;
            Console.WriteLine("Result: " + totalAddition);
        }
        public void Subtraction(int number1, int number2)
        {
            int totalSubtraction = number1 - number2;
            Console.WriteLine("Result: " + totalSubtraction);
        }

        public void Multiplication(int number1, int number2)
        {
            int totalMultiplication = number1 * number2;
            Console.WriteLine("Result: " + totalMultiplication);
        }
        public void Division(int number1, int number2)
        {
            int totalDivision = number1 / number2;
            Console.WriteLine("Result: " + totalDivision);
        }


    }
}