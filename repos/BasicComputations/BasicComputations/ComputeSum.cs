using System;
using System.Collections.Generic;
using System.Text;

namespace BasicComputations
{
    class ComputeSum
    {
        public static void Main()
        {
            Console.WriteLine("Enter the 2 no");
            int n1=Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            int sum = n1 + n2;
            if (sum == n1 * 2)
                Console.WriteLine(sum + n1);
            else
                Console.WriteLine(sum);
     


        }
    }
}
