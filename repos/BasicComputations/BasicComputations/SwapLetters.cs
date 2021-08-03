using System;
using System.Collections.Generic;
using System.Text;

namespace BasicComputations
{
    class SwapLetters
    {
        public static void Main()
        {
            Console.WriteLine("Enter String");
            String str = Console.ReadLine();
            Console.WriteLine(str.Length - 1);
            String new_str = str.Substring(str.Length - 1) + str.Substring(2, 3) + str.Substring(0,1);
            Console.WriteLine(new_str);
        }
    }
}
        