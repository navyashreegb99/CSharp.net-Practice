using System;
using System.Collections.Generic;
using System.Text;

namespace BasicComputations
{
    class PrintName
    {
       public static void Main()
        {
            Console.WriteLine("Enter two numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum of {0}+{1}={2}", num1, num2, num1 / num2);
        }

    }
}
