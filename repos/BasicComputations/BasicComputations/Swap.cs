using System;
using System.Collections.Generic;
using System.Text;

namespace BasicComputations
{
    class Swap
    {
        public static void Main()
        {
            int firstNumber = 10;
            int secondNumber = 20;

            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;
            Console.WriteLine("Testing");
            Console.WriteLine("Two no after swaping firstNumber={0} and secondNumber={1}", firstNumber, secondNumber);
        }
    }
}
