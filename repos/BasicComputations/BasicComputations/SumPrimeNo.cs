using System;
using System.Collections.Generic;
using System.Text;

namespace BasicComputations
{
    class SumPrimeNo
    {
        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int prime = 1;
            for(int j=2;j<=n;j++)
            {
                for(int i = 2; i < j; i++)
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
                    sum = sum + j;
            }
            Console.WriteLine("Sum of Prime nos below{0}={1}", n, sum);
        }
    }
}
