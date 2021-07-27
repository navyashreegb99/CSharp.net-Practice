using System;

namespace BasicComputations
{
    class Program
    {
        public int add(int a, int b)
        {
            int res = a + b;
            return res;
        }

        public int sub(int a, int b)
        {
            int res = a - b;
            return res;
        }

        public int mul(int a, int b)
        {
            int res = a * b;
            return res;
        }

        public int div(int a, int b)
        {
            int res = a / b;
            return res;
        }

        static void Main(string[] args)
        {
            int num1, num2;
            Program p = new Program();
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sum of {0}+{1}={2}", num1,num2,p.add(num1, num2));
            Console.WriteLine("Sub of {0}+{1}={2}", num1, num2, p.sub(num1, num2));
            Console.WriteLine("Mul of {0}+{1}={2}", num1, num2, p.mul(num1, num2));
            Console.WriteLine("Div of {0}+{1}={2}", num1, num2, p.div(num1, num2));
        }
    }
}
