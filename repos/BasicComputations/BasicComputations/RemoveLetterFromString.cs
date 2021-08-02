using System;
using System.Collections.Generic;
using System.Text;

namespace BasicComputations
{
    class RemoveLetterFromString
    {
       public static void Main()
        {
            Console.WriteLine("Enter string");
            String str = (Console.ReadLine());
            Console.WriteLine("Enter letter");
            char c = Convert.ToChar(Console.ReadLine());
            int num = str.IndexOf(c);
            str = str.Remove(num, 1);
            Console.WriteLine(str);
        }
    }
}
