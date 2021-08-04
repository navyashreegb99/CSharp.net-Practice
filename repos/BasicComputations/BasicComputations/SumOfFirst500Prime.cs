using System;
using System.Collections.Generic;
using System.Text;

namespace BasicComputations
{
    class SumOfFirst500Prime
    {
        public static void Main()
        {

            int sum = 0;
            int prime = 1;
            int count = 1;
            int j = 2;
            while (count <= 500) 
            {
                for (int i = 2; i < j; i++)
                {
                    if (j % i == 0)
                    {
                        prime = 0;
                        break;
                    }
                    else
                    {
                        prime = 1;
                       
                    }
                }
                if (prime == 1)
                {
                    sum = sum + j;
                    Console.WriteLine("{0}", j);
                    count++;
                }
                    j++;
            }
        
            Console.WriteLine("Sum of first 500 Prime nos= {0}", sum);
        }
    }
}
