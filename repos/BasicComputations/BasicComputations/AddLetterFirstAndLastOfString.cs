using System;
using System.Collections.Generic;
using System.Text;

namespace BasicComputations
{
    class AddLetterFirstAndLastOfString
    {
        public static void Main()
        {
            string str = "The quick brown fox jumps over the lazy dog.";
            string new_str = str.Substring(0,1) + str + str.Substring(0,1);
            Console.WriteLine(new_str);
              

        }
    }
}
