using System;
using System.Collections.Generic;
using System.Text;

namespace BasicComputations
{
    class multTable
    {
        public static void Main()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Multiplcation table for {0} is", num);
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}*{1}={2}", num, i, num * i);
            }

        }
    }
}
